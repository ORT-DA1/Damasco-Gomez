using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic.Exceptions
{
    public class InvalidTextException : LogicException
    {

        private static readonly string message = "Mensajeincorrecto. Ej: ABC 1234 60 10:00";

        public InvalidTextException() : base(message)
        {

        }
    }
}
