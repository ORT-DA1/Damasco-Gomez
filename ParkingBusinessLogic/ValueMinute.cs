using ParkingBusinessLogic.Exceptions;
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
            ValuePerMinutes = 3;
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

        public void ChangeValue(int NewValue)
        {
            ValuePerMinutes = NewValue;
        }
    }
}
