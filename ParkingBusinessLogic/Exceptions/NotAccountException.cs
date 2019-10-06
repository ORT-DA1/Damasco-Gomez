using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic.Exceptions
{
    public class NotAccountException : LogicException
    {
        private static readonly string message = "Not Account with this number, try to add a new one.";

        public NotAccountException() : base(message)
        {

        }
    }
}
