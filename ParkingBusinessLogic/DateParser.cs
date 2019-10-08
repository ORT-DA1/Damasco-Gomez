using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic
{
    class DateParser
    {
        public DateParser()
        {

        }

        public String ParserTimeFromCheck(string txt)
        {
            txt = txt.Trim();
            String[] arrayTxt = txt.Split(' ');
            if (arrayTxt.Length == 0)
            {
                throw new InvalidTxtInCheck();
            } else
            {
                return arrayTxt[0];
            }
        }
        public String ParserTimeFromTxt(string txt)
        {
            txt = txt.Trim();
            String[] arrayTxt = txt.Split(' ');
            if (arrayTxt.Length == 0)
            {
                throw new InvalidTxtInCheck();
            }
            else
            {
                return arrayTxt[0];
            }
        }

        public String ParserDay(string txt)
        {
            return "";
        }

        public bool ValidateTime(string startTime)
        {
            bool auxReturn = false;
            if (!startTime.Equals("") && startTime.Contains(':'))
            {
                string[] hourmin = startTime.Split(':');
                string hour = hourmin[0];
                int hours = Int32.Parse(hour);
                if ((hours >= 10) && (hours <= 18))
                {
                    return true;

                }
            }

            return auxReturn;
        }
        public bool ValidateDay(string MyDay)
        {
            return true;
        }

        public string GetTimeFromCheck(string myTime)
        {
            if (ValidateTime(ParserTimeFromCheck(myTime)))
            {
                return myTime;
            }
            throw new InvalidStartTimeException();
        }

        public string GetTimeFromTxt(string myTime)
        {
            if (ValidateTime(ParserTimeFromTxt(myTime)))
            {
                return myTime;
            }
            throw new InvalidStartTimeException();
        }

        public string GetDayFromCheck(string myDay)
        {
            if (ValidateDay(ParserDay(myDay)))
            {
                return myDay;
            }
            throw new InvalidDayException();
        }
    }
}
