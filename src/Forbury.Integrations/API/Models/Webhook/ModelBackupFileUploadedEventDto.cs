namespace Forbury.Integrations.API.Models.Webhook
{
    public class ModelBackupFileUploadedEventDto : ModelEventDto
    {
        public override WebhookType Type => WebhookType.ModelBackupFileUploaded;
    }
}