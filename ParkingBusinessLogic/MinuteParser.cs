using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic
{
    public abstract class MinuteParser
    {

        public abstract int GetCantMinutes(string msg);
    
        public String ParseCantMinutes(string msg)
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
        public int ValidateDigitAndGraterThanZero(String minutes)
        {
            if (minutes.All(char.IsDigit) && (Int32.Parse(minutes) > 0))
            {
                return Int32.Parse(minutes);
            }
            else
            {
                return -1;
            }

        }
        public int CalculateCantMinutesFromPurchase(string initHour, string finishHour)
        {
            string[] parserInit = initHour.Split(':');
            string[] parserFin = finishHour.Split(':');
            int canMinutes = ((Int32.Parse(parserFin[0]) - Int32.Parse(parserInit[0])) * 60) + (Int32.Parse(parserFin[1]) - Int32.Parse(parserInit[1]));
            return canMinutes;
        }

    }
}
