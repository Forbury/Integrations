using System;
using System.Threading.Tasks;
using Forbury.Integrations.API.v1.Dto;
using Forbury.Integrations.API.v1.Dto.Enums;

namespace Forbury.Integrations.API.v1.Interfaces
{
    public interface IForburyApiService
    {
        Task<PagedResult<TeamDto>> GetTeams(int amount = 20, 
            int page = 1);

        Task<PagedResult<ModelDto>> GetModelDataForTeam(int teamId,
            DateTime? fromDate = null,
            ModelType? modelType = null,
            int amount = 20,
            int page = 1);
    }
}
