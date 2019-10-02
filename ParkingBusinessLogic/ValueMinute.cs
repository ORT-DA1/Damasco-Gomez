﻿using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic
{
    public class ValueMinute
    {
        private int  valuePerMinutes;
        public int ValuePerMinutes
        {
            get
            {
                return valuePerMinutes;
            }
            private set
            {

                valuePerMinutes = value;

            }
        }
        public ValueMinute()
        {
            ValuePerMinutes = 30;
        }
        public ValueMinute(int value)
        {
            ValuePerMinutes = value;

        }
        public int TotalPrice(int cantMinutes)
        {
            if (cantMinutes > 0) {
                return cantMinutes * valuePerMinutes;

            }
            else
            {
                throw new NegativeNumberException();
            }
           

        }
    }
}