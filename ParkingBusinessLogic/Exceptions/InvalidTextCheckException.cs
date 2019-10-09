using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic.Exceptions
{
    public class InvalidTextCheckException : LogicException
    {
        private static readonly string message = "Text show have the format '11/11 12:45' .";

        public InvalidTextCheckException() : base(message)
        {

        }
    }
}
