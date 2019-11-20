using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic.Exceptions
{
    public class NoPurchasewithDate : LogicException
    {
        private static readonly string message = "There is no purchase with this date and time ";

        public NoPurchasewithDate() : base(message)
        {

        }
    }
}
