using System;

namespace Forbury.Integrations.API.Exceptions
{
    public class WebhookConfigurationException : Exception
    {
        public WebhookConfigurationException(string message): base(message) { }
    }
}