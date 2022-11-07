using System;
using System.Collections.Generic;
using System.Text;

namespace Forbury.Integrations.API.Exceptions
{
    public class ForburyAuthenticationException : Exception
    {
        public ForburyAuthenticationException(string message) : 
            base(message) { }

        public ForburyAuthenticationException(string message, Exception innerException) :
            base(message, innerException) { }
    }
}
