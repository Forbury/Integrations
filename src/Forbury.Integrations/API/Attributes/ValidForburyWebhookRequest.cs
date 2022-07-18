using System;
using System.Text;
using Forbury.Integrations.Helpers.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Forbury.Integrations.API.Attributes
{
    internal class ValidForburyWebhookRequest : IAuthorizationFilter
    {
        private readonly string _secret;

        public ValidForburyWebhookRequest(string secret)
        {
            _secret = secret;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var request = context.HttpContext.Request;
            request.EnableBuffering();

            var buffer = new byte[Convert.ToInt32(request.ContentLength)];
            request.Body.ReadAsync(buffer, 0, buffer.Length).Wait();

            var result = Encoding.UTF8.GetString(buffer);
            if (!context.HttpContext.Request.Headers.IsSignatureCompatible(_secret, result))
            {
                context.Result = new UnauthorizedResult();
            }

            request.Body.Position = 0; 
        }
    }
}