using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic.Exceptions
{
    public class SelectCountryException : LogicException
    {

        private static readonly string message = "You must select a country";
        public SelectCountryException() : base(message)
        {

        }
    }
}
