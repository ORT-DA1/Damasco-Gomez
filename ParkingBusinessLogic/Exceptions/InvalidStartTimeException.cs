using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic.Exceptions
{
    public class InvalidStartTimeException : LogicException
    {

            private static readonly string message = "The number is invalid";

            public InvalidStartTimeException() : base(message)
            {

            }
        
    }
}
