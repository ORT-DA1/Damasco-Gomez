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
                throw new InvalidTextExceptionUruguay();
            }
        }

        public override string ParseCantMinutes(string msg)
        {
            string minutes = "";
            if (msg.Contains(' '))
            {
                string[] msgList = msg.Split(' ');

                if (msgList[msgList.Length - 1].Contains(':'))
                {
                    minutes = msgList[msgList.Length - 2];
                }
                else
                {
                    minutes = msgList[msgList.Length - 1];
                }

            }
            return minutes;
        }




    }
}
