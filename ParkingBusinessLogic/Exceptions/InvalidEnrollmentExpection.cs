using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic.Exceptions
{
    class InvalidEnrollmentExpection: LogicException
    {

        private static readonly string message = "Enrollment is Invalid";

        public InvalidEnrollmentExpection() : base(message)
        {

        }
    }
}
