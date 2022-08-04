namespace Forbury.Integrations.API.v1.Dto.File
{
    public abstract class FileDto
    {
        public string Id { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
    }
}
