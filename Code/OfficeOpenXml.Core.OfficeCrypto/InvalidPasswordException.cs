using System;
using System.Collections.Generic;
using System.Text;

namespace OfficeOpenXml.Core.OfficeCrypto
{
    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException() : base() { }
        public InvalidPasswordException(String message) : base(message) { }
        public InvalidPasswordException(String message, Exception innerException)
            : base(message, innerException) { }
    }
}
