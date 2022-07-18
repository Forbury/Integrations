using System;
using System.Collections.Generic;
using System.Text;

namespace Forbury.Integrations.API.Exceptions
{
    internal class ForburyAuthenticationException : Exception
    {
        public ForburyAuthenticationException(string message, Exception innerException) :
            base(message, innerException) { }
    }
}
