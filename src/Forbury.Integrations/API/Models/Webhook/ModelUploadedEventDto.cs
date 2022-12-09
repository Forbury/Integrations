namespace Forbury.Integrations.API.Models.Webhook
{
    public class ModelUploadedEventDto : ModelEventDto
    {
        public int TeamId { get; set; }
        public override WebhookType Type => WebhookType.ModelUploaded;
    }
}