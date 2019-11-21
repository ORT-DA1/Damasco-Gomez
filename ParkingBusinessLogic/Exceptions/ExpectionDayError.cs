using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic.Exceptions
{
    public class ExpectionDayError : LogicException
    {
        private static readonly string message = "Day is not in correct format! Should be 12/10";

        public ExpectionDayError() : base(message)
        {

        }
    }
}
