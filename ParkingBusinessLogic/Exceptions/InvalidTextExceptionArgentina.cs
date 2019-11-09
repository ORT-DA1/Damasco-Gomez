using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic.Exceptions
{
    public class InvalidTextExceptionArgentina : LogicException
    {
        private static readonly string message = "Message is incorrect. The format should be: ABC 1234  10:00 35";

        public InvalidTextExceptionArgentina() : base(message)
        {

        }
    }
}
