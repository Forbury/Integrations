namespace Forbury.Integrations.API.Models.Webhook
{
    public class ModelExtractionsCompletedEventDto : BaseEventDto
    {
        public int ModelId { get; set; }
        public string ExternalId { get; set; }
        public int ExtractionCount { get; set; }
        public override WebhookType Type => WebhookType.ModelExtractionsCompleted;
    }
}