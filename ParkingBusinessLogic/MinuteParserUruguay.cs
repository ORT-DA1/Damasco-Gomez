using ParkingBusinessLogic.Exceptions;
using System;
using System.Linq;

namespace ParkingBusinessLogic
{
    public class MinuteParserUruguay : MinuteParser
    {
        public MinuteParserUruguay() { }
        public bool ValidateMinutesMultiple30(int minutes)
        {
            if ((minutes % 30) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetCantMinutes(string msg)
        {
            string cantMinutes = ParseCantMinutes(msg);
            int intCantMinutes = ValidateDigitAndGraterThanZero(cantMinutes);


            if (ValidateMinutesMultiple30(intCantMinutes))
            {
                return intCantMinutes;
            }
            else
            {
                throw new InvalidTextException();
            }
        }

       

       

        
    }
}
