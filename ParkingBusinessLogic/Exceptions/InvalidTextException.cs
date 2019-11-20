﻿using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic.Exceptions
{
    public class InvalidTextException  : LogicException
    {
        private static readonly string message = "Text was invalid, try again.";

        public InvalidTextException() : base(message)
        {

        }
    }
}
