using Forbury.Integrations.API.v1.Dto.Enums;

namespace Forbury.Integrations.API.v1.Dto.File
{
    public class ModelExtractionDto : FileDto
    {
        public ModelExtractionType ExtractionType { get; set; }
        public string SheetName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
