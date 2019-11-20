using ParkingBusinessLogic.Exceptions;
using System;

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
            try
            {
                valuePerMinutes = Int32.Parse(NewValue.Trim());
            }

            catch
            {
                throw new NegativeNumberException();
            }

        }

    }
}
