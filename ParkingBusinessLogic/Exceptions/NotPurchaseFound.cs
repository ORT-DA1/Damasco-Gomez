using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic.Exceptions
{
    public class NotPurchaseFound : LogicException
    {
        private static readonly string message = "There is not purchase with that content";
        public NotPurchaseFound() : base(message)
        {

        }
    }
}
