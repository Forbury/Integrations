using System;

namespace Forbury.Integrations.API.Models.Webhook
{
    public abstract class BaseEventDto
    {
        public string CreatedByEmail { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
        public abstract WebhookType Type { get; }
    }
}
