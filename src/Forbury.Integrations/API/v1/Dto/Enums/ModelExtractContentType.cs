using System;
using System.Net.Mime;

namespace Forbury.Integrations.API.v1.Dto.Enums
{
    public enum ModelExtractFileType
    {
        Pdf = 0,
        Jpeg = 1
    }

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
