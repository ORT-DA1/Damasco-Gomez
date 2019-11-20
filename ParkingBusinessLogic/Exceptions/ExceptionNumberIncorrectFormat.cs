using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic.Exceptions
{
    public class ExceptionNumberIncorrectFormat : LogicException
    {
        private static readonly string message = "The number does not have the correct format, should be: ";

        public ExceptionNumberIncorrectFormat(string numFormat) : base(message + numFormat)
        {

        }
    }
}
