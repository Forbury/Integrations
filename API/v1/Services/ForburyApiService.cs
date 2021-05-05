using System;
using System.Net.Http;
using System.Threading.Tasks;
using Forbury.Integrations.API.Interfaces;
using Forbury.Integrations.API.v1.Dto;
using Forbury.Integrations.API.v1.Dto.Enums;
using Forbury.Integrations.API.v1.Interfaces;
using Forbury.Integrations.Helpers.Extensions;
using IdentityModel.Client;
using Microsoft.AspNetCore.Http.Extensions;

namespace Forbury.Integrations.API.v1.Services
{
    public class ForburyApiService : IForburyApiService
    {
        private static Models.TokenResponse _token;

        private readonly HttpClient _httpClient;
        private readonly IForburyAuthenticationService _forburyAuthenticationService;

        public ForburyApiService(HttpClient httpClient,
            IForburyAuthenticationService forburyAuthenticationService)
        {
            _forburyAuthenticationService = forburyAuthenticationService;
            _httpClient = httpClient;
            _httpClient.SetBearerToken(_token?.AccessToken);
        }

        public async Task<PagedResult<TeamDto>> GetTeams(int amount = 20, 
            int page = 1)
        {
            await EnsureAuthorised();

            QueryBuilder queryBuilder = GetPagedQueryBuilder(amount, page);
            HttpResponseMessage response = await _httpClient.GetAsync($"team{queryBuilder.ToQueryString()}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsObjectAsync<PagedResult<TeamDto>>();
        }

        public async Task<PagedResult<ModelDto>> GetModelDataForTeam(int teamId, 
            DateTime? fromDate = null, 
            ModelType? modelType = null,
            int amount = 20,
            int page = 1)
        {
            await EnsureAuthorised();

            QueryBuilder queryBuilder = GetPagedQueryBuilder(amount, page);
            if (fromDate != null) queryBuilder.Add("fromDate", fromDate.ToString());
            if (modelType != null) queryBuilder.Add("modelType", modelType.ToString());

            HttpResponseMessage response = await _httpClient.GetAsync($"team/{teamId}/model{queryBuilder.ToQueryString()}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsObjectAsync<PagedResult<ModelDto>>();
        }

        private QueryBuilder GetPagedQueryBuilder(int amount, int page)
        {
            return new QueryBuilder
            {
                { "amount", amount.ToString() },
                { "page", page.ToString() }
            };
        }

        private async Task EnsureAuthorised()
        {
            if (_token != null && DateTime.Now < _token.ExpiresOn)
                return;

            await SetAccessToken();
        }

        private async Task SetAccessToken()
        {
            _token = await _forburyAuthenticationService.GetAccessTokenAsync();
            _httpClient.SetBearerToken(_token?.AccessToken);
        }
    }
}
