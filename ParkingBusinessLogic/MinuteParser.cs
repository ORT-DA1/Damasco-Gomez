using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic
{
    public class MinuteParser
    {
       public MinuteParser() { }
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

        public int GetCantMinutes(string msg)
        {
            string cantMinutes = ParseCantMinutes(msg);
            int intCantMinutes = ValidateDigit(cantMinutes);


            if (ValidateMinutesMultiple30(intCantMinutes))
            {
                return intCantMinutes;
            }
            else
            {
                throw new InvalidTextException();
            }
        }

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
                    minutes= msgList[msgList.Length - 1];
                }
                
            }
            return minutes;
        }

        public int ValidateDigit(String minutes)
        {
            if (minutes.All(char.IsDigit))
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
            int canMinutes = ((Int32.Parse(parserFin[0]) - Int32.Parse(parserInit[0])) * 60 ) + (Int32.Parse(parserFin[1]) - Int32.Parse(parserInit[1]) );
            return canMinutes;
        }
    }
}
