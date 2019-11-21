using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic.Exceptions
{
    class ExceptionIncorrectTime : LogicException
    {
        private static readonly string message = "Time is not in correct format! Should be 12:10, between 10 and 18";

        public ExceptionIncorrectTime() : base(message)
        {

        }
    }
}
