using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic.Exceptions
{
    public class InvalidAccountArgentinaException : LogicException
    {

        private static readonly string message = "The account has two rules, number like 123-456-78, 8 digits with no spaces, and the balance should be positive number.";

        public InvalidAccountArgentinaException() : base(message)
        {

        }
    }
}
