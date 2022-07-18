using System;

namespace Forbury.Integrations.API.v1.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public DateTimeOffset ReleaseDate { get; set; }
        public string ImportantNotes { get; set; }
        public string Notes { get; set; }
        public string DownloadUrl { get; set; }
    }
}
