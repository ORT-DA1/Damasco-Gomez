using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic.Exceptions
{
    public class TextIncompliteException : LogicException
    {
        private static readonly string message = "Nedd to complete ALL values.";

        public TextIncompliteException() : base(message)
        {

        }
    }
}
