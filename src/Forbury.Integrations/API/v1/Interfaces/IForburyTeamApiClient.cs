using System;
using System.Threading;
using System.Threading.Tasks;
using Forbury.Integrations.API.v1.Dto;
using Forbury.Integrations.API.v1.Dto.Enums;
using Forbury.Integrations.API.v1.Dto.Model;
using Forbury.Integrations.API.v1.Dto.Property;
using Forbury.Integrations.API.v1.Dto.Team;

namespace Forbury.Integrations.API.v1.Interfaces
{
    public interface IForburyTeamApiClient : IForburyApiClient
    {
        Task<PagedResult<TeamDto>> GetTeams(int amount = 20, 
            int page = 1,
            CancellationToken cancellationToken = default);

        Task<TeamDetailedDto> GetTeamById(int teamId,
            CancellationToken cancellationToken = default);

        Task<PagedResult<ModelDto>> GetModelsByTeamId(int teamId,
            DateTime? fromDate = null,
            ModelType? modelType = null,
            int amount = 20,
            int page = 1,
            CancellationToken cancellationToken = default);

        Task<PagedResult<PropertyDto>> GetPropertiesByTeamId(int teamId,
            int amount = 20,
            int page = 1,
            CancellationToken cancellationToken = default);

        Task<PropertyDetailedDto> GetPropertyByTeamId(int teamId,
            int propertyId,
            CancellationToken cancellationToken = default);
    }
}
