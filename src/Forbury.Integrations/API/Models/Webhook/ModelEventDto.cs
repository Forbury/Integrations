namespace Forbury.Integrations.API.Models.Webhook
{
    public abstract class ModelEventDto : BaseEventDto
    {
        public int ModelId { get; set; }
        public string ExternalId { get; set; }
    }
}
