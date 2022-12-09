﻿using System.Threading;
using System.Threading.Tasks;
using Forbury.Integrations.API.v1.Dto.Model.Commercial;

namespace Forbury.Integrations.API.v1.Interfaces.Model
{
    public interface IForburyModelCommercialApiClient : IForburyModelApiClient
    {
        Task<ModelCommercialDetailedDto> GetModelById(int modelId,
            CancellationToken cancellationToken = default);
    }
}
