using System;
using System.Net;

namespace Forbury.Integrations.API.Exceptions
{
    public class ForburyApiException : Exception
    {
        public HttpStatusCode HttpStatusCode { get; set; }

        public ForburyApiException(string message) : base(message) { }

        public ForburyApiException(string message, HttpStatusCode httpStatusCode) : 
            base(message) 
        {
            HttpStatusCode = httpStatusCode;
        }

        public ForburyApiException(string message, Exception innerException) :
            base(message, innerException)
        { }
    }
}
