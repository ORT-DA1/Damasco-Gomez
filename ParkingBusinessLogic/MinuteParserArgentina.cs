using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic
{
    public class MinuteParserArgentina : MinuteParser
    {
        public override int GetCantMinutes(string msg)
        {
            string cantMinutes = ParseCantMinutes(msg);
            int intCantMinutes = ValidateDigitAndGraterThanZero(cantMinutes);
            if (intCantMinutes != -1){
                return intCantMinutes;
            }
            else
            {
                 throw new InvalidTextException();
            }




        }

    }
}
