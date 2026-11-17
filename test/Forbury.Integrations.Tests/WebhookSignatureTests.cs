using Forbury.Integrations.API;
using Forbury.Integrations.Helpers.Extensions;
using Microsoft.AspNetCore.Http;
using NUnit.Framework;

namespace Forbury.Integrations.Tests
{
    public class WebhookSignatureTests
    {
        private const string Secret = "webhook-secret";
        private const string Body = "{\"id\":1}";

        // HMAC-SHA256 of Body with Secret, computed independently with openssl.
        private const string Signature = "sha256=70-C1-3E-23-2E-9A-FE-3F-AB-AC-2F-01-78-B1-F0-B6-B2-AE-79-29-A0-FC-7A-11-9E-00-58-DE-10-38-74-92";

        [Test]
        public void IsSignatureCompatible_AcceptsTheCorrectSignature()
        {
            var headers = new HeaderDictionary { { Constants.SignatureHeaderName, Signature } };

            Assert.That(headers.IsSignatureCompatible(Secret, Body), Is.True);
        }

        [Test]
        public void IsSignatureCompatible_RejectsATamperedBody()
        {
            var headers = new HeaderDictionary { { Constants.SignatureHeaderName, Signature } };

            Assert.That(headers.IsSignatureCompatible(Secret, "{\"id\":2}"), Is.False);
        }

        [Test]
        public void IsSignatureCompatible_RejectsAMissingHeader()
        {
            Assert.That(new HeaderDictionary().IsSignatureCompatible(Secret, Body), Is.False);
        }
    }
}
