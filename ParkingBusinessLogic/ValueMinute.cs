using ParkingBusinessLogic.Exceptions;
using System;
using System.Linq;

namespace ParkingBusinessLogic
{
    public class ValueMinute
    {
        private int valuePerMinutes;
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
            if (cantMinutes > 0)
            {
                return cantMinutes * valuePerMinutes;

            }
            else
            {
                throw new NegativeNumberException();
            }


        }

        public void ChangeValue(string NewValue)
        {
            if (NewValue.All(char.IsDigit) && Int32.Parse(NewValue)>0 ) { 
                valuePerMinutes = Int32.Parse(NewValue.Trim());
            }
            else
            {
                throw new NegativeNumberException();
            }

        }

    }
}
