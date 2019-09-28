using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic
{
    public class Tools
    {
       
        public bool ValidateMinutesMultiple30(int minutes)
        {
            if ((minutes % 30) == 0)
            {

                return true;

            }
            else
            {
                throw new InvalidTextException();
            }


        }

        public int BreakDownCantMinutes(string msg)
        {

            int cantMinutes = ParseCantMinutes(msg);
            ValidateMinutesMultiple30(cantMinutes);
            return cantMinutes;



        }

        public int ParseCantMinutes(string msg)
        {
            
                
            string[] msgList = msg.Split(' ');
            string minutes = "";
            if (msgList.Length >= 2)
            {
                if (msgList.Length == 3 && msgList[2].All(char.IsDigit) )
                {
                    minutes = msgList[2];
                }
                else if (msgList[1].All(char.IsDigit))
                {
                    minutes = msgList[1];
                } else
                {
                    throw new InvalidTextException();
                }
            }
            return Convert.ToInt32(minutes);

        }
    }
}
