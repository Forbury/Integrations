using Forbury.Integrations.API.v1.Dto.Enums;
using System;
using System.Net.Mime;

namespace Forbury.Integrations.API.v1.Extensions
{
    public static class ModelExtractContentTypeExtensions
    {
        public static string ToMediaType(this ModelExtractFileType contentType)
        {
            return contentType switch
            {
                ModelExtractFileType.Pdf => MediaTypeNames.Application.Pdf,
                ModelExtractFileType.Jpeg => MediaTypeNames.Image.Jpeg,
                _ => throw new NotSupportedException("Content type not supported.")
            };
        }
    }
}
