using System.Collections.Generic;

namespace Forbury.Integrations.API.Models.Configuration
{
    public class ForburyConfiguration
    {
        public ApiConfiguration Api { get; set; }
        public AuthenticationConfiguration Authentication { get; set; }
        public List<WebhookEndpointConfiguration> Webhooks { get; set; }
    }
}
