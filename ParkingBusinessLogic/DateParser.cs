using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic
{
    public class DateParser
    {
        public DateParser()
        {

        }

        public String ParserTimeFromCheck(string txt)
        {
            txt = txt.Trim();
            String[] arrayTxt = txt.Split(' ');
            if (arrayTxt.Length <= 1)
            {
                throw new InvalidTxtInCheck();
            } else
            {
                return arrayTxt[0];
            }
        }
        public String ParserTimeFromTxt(string txt)
        {
            string starTime = "";
            txt = txt.Trim();
            string[] msgList = txt.Split(' ');
            if (txt.Contains(':'))
            {

                if (msgList.Length == 3)
                {
                    starTime = msgList[2];

                }
                else if (msgList.Length == 4)
                {
                    starTime = msgList[3];


                }
                else
                {
                    starTime = DateTime.Now.ToString("HH:mm");
                }
                
            }
            return starTime;
        }

        public String ParserDay(string txt)
        {
            txt = txt.Trim();
            String[] arrayTxt = txt.Split(' ');
            if (arrayTxt.Length <= 1)
            {
                throw new InvalidTxtInCheck();
            }
            else
            {
                return arrayTxt[1];
            }
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
        public bool ValidateDateNumber (string MyMonth , string MyDay)
        {
            int ThisDay = Int32.Parse(DateTime.Now.ToString("dd"));
            int ThisMonth = Int32.Parse(DateTime.Now.ToString("MM"));
            return ((Int32.Parse(MyMonth) <= ThisMonth) && (Int32.Parse(MyDay) <= ThisDay));
        }

        public bool ValidateNumberArray(string[] stringArray)
        {
            bool AreNumberOnly = true;
            int count = 0;
            while (AreNumberOnly && count<stringArray.Length)
            {
                AreNumberOnly = stringArray[count].All(char.IsDigit);
                count++;
            }
            return AreNumberOnly;
        }
        public bool ValidateDay(string MyDay)
        {
            if (MyDay.Contains('/'))
            {
                string[] parserDay = MyDay.Split('/');
                return parserDay.Length == 2 && ValidateNumberArray(parserDay) && ValidateDateNumber(parserDay[0],parserDay[1]); 
            }
            else
            {
                throw new InvalidTxtInCheck();
            }
        }

        public String FormatDay(string MyDate)
        {
            string[] formatDay = MyDate.Split('/');
            return formatDay[0] + "-" +formatDay[1];
        }

        public string GetTimeFromCheck(string myTime)
        {
            string parserTime = ParserTimeFromTxt(myTime);
            if (ValidateTime(ParserTimeFromCheck(parserTime)))
            {
                return parserTime;
            }
            throw new InvalidStartTimeException();
        }

        public string GetTimeFromTxt(string myTime)
        {
            string parserTime = ParserTimeFromTxt(myTime);
            if (ValidateTime(parserTime))
            {
                return parserTime;
            }
            throw new InvalidStartTimeException();
        }

        public string GetDayFromCheck(string myDay)
        {
            string parserDay = ParserDay(myDay);
            if (ValidateDay(ParserDay(parserDay)))
            {
                return FormatDay(parserDay);
            }
            throw new InvalidDayException();
        }
    }
}
