using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic.Exceptions
{
    public class HaveAccountException : LogicException
    {
    private static readonly string message = "Account already created, add balance not create new one.";

        public HaveAccountException() : base(message)
        {

        }
    }
}
