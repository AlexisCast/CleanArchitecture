using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ApplicationLayer.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException() : base("Validation Error.") { }
        public ValidationException(string message) : base(message) { }
    }
}
