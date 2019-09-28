using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic.Exceptions
{
    public class InsufficientBalanceException : LogicException
    {
        private static readonly string message = "Saldo Insuficiente";

        public InsufficientBalanceException() : base(message)
        {

        }

    }
}
