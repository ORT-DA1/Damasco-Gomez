using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic.Exceptions
{
    class InvalidDayException : LogicException
    {
        private static readonly string message = "The day is not correct. ";

        public InvalidDayException() : base(message)
        {

        }
    }
}
