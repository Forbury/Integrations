namespace Forbury.Integrations.API.Models.Webhook
{
    public class ModelExtractionsCompletedEventDto : ModelEventDto
    {
        public int ExtractionCount { get; set; }
        public override WebhookType Type => WebhookType.ModelExtractionsCompleted;
    }
}