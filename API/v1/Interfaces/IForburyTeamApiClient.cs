﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Forbury.Integrations.API.v1.Dto;
using Forbury.Integrations.API.v1.Dto.Enums;

namespace Forbury.Integrations.API.v1.Interfaces
{
    public interface IForburyTeamApiClient
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

        Task<ModelDetailedDto> GetModelByTeamId(int teamId,
            int modelId,
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