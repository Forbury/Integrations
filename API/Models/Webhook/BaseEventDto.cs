using System;

namespace Forbury.Integrations.API.Models.Webhook
{
    public abstract class BaseEventDto
    {
        public Guid UserId { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
        public abstract WebhookType Type { get; }
    }
}
