﻿using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic.Exceptions
{
    public class NegativeNumberException : LogicException
    {
        private static readonly string message = "Numero ingresado no debe ser  negativo";

        public NegativeNumberException() : base(message)
        {

        }
    }
}
