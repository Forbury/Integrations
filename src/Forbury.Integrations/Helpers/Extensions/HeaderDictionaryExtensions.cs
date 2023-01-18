using System;
using System.Security.Cryptography;
using System.Text;
using Forbury.Integrations.API;
using Forbury.Integrations.API.Exceptions;
using Microsoft.AspNetCore.Http;

namespace Forbury.Integrations.Helpers.Extensions
{
    public static class HeaderDictionaryExtensions
    {
        public static void EnforceSignatureCompatible(this IHeaderDictionary headers, string secret, string body)
        {
            if (!headers.IsSignatureCompatible(secret, body))
            {
                throw new WebhookSigningException();
            }
        }

        public static bool IsSignatureCompatible(this IHeaderDictionary headers, string secret, string body)
        {
            if (!headers.ContainsKey(Constants.SignatureHeaderName))
            {
                return false;
            }

            var receivedSignature =
                headers[Constants.SignatureHeaderName].ToString()
                    .Split('=');

            string computedSignature;
            switch (receivedSignature[0])
            {
                case "sha256":
                    var secretBytes = Encoding.UTF8.GetBytes(secret);
                    using (var hasher = new HMACSHA256(secretBytes))
                    {
                        var data = Encoding.UTF8.GetBytes(body);
                        computedSignature = BitConverter.ToString(hasher.ComputeHash(data));
                    }

                    break;
                default:
                    throw new NotImplementedException();
            }

            return computedSignature == receivedSignature[1];
        }
    }
}