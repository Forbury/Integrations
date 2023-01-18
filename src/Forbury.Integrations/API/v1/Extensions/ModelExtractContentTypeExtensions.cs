using Forbury.Integrations.API.v1.Dto.Enums;
using System;
using System.Net.Mime;

namespace Forbury.Integrations.API.v1.Extensions
{
    public static class ModelExtractContentTypeExtensions
    {
        public static string ToMediaType(this ModelExtractFileType contentType)
        {
            switch (contentType)
            {
                case ModelExtractFileType.Pdf:
                    return MediaTypeNames.Application.Pdf;
                case ModelExtractFileType.Jpeg:
                    return MediaTypeNames.Image.Jpeg;
                default:
                    throw new NotSupportedException("Content type not supported.");
            }
        }
    }
}
