using System;

namespace NetcoreV3.SonarQ.Apps.DomainExceptions
{
    public class ValorInvalidoException : Exception
    {
        public ValorInvalidoException(string message) : base(message)
        {
        }

        public ValorInvalidoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}