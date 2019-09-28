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
        public bool ValidateMinutesMultiple30(string minutes)
        {
            int min = Int32.Parse(minutes);
            if ((min % 30) == 0)
            {

                return true;

            }
            else
            {
                throw new InvalidTextException();
            }


        }

        public string BreakDownCantMinutes(string msg)
        {

            string cantMinutes = ParseCantMinutes(msg);
            ValidateMinutesMultiple30(cantMinutes);
            return cantMinutes;



        }

        public string ParseCantMinutes(string msg)
        {

            string[] msgList = msg.Split(' ');

            string minutes = "";


            if (msgList.Length >= 2)
            {
                if (msgList[0].Length == 3)
                {

                    minutes = msgList[2];


                }
                else
                {

                    minutes = msgList[1];

                }

            }
            return minutes;

        }
    }
}
