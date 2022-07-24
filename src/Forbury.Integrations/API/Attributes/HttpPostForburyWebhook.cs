using System;
using System.Linq;
using Forbury.Integrations.API.Exceptions;
using Forbury.Integrations.API.Models.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Forbury.Integrations.API.Attributes
{
    public class HttpPostForburyWebhook : HttpPostAttribute, IFilterFactory
    {
        private readonly string _webhookConfigMatch;

        public HttpPostForburyWebhook(string template, string webhookConfigMatch = null) : base(template)
        {
            _webhookConfigMatch = webhookConfigMatch;
        }

        public bool IsReusable => false;

        public IFilterMetadata CreateInstance(IServiceProvider serviceProvider)
        {
            var configOptions = serviceProvider.GetService<IOptions<ForburyConfiguration>>();
            var matchString = _webhookConfigMatch ?? Template;
            var webhookEndpointConfiguration = configOptions.Value.Webhooks?.SingleOrDefault(w => string.Equals(w.Endpoint, matchString, StringComparison.CurrentCultureIgnoreCase));

            if (webhookEndpointConfiguration == null)
            {
                throw new WebhookConfigurationException($"Could not find a configuration for endpoint: {matchString}");
            }

            return new ValidForburyWebhookRequest(webhookEndpointConfiguration.Secret); 
        }
    }
}