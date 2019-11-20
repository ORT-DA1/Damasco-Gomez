using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic.Exceptions
{
    public class DataBaseException : LogicException
    {
        private static readonly string message = "There is a problem in the data base: ";

        public DataBaseException(string typeOfProblem) : base(message + typeOfProblem)
        {

        }
    }
}
