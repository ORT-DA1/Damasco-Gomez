using ParkingBusinessLogic.Exceptions;
using System;
using System.Linq;

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
                return "";
            }
            else
            {
                return arrayTxt[1];
            }
        }
        public String ParserTimeFromTxt(string txt)
        {
            txt = txt.Trim();
            //LicensePlateParser lp = new LicensePlateParser();
            //MinuteParserUruguay mp = new MinuteParserUruguay();
            //string parserLicensePlate = lp.ParseLicensePlate(txt);
            //string parserMinutes = mp.ParseCantMinutes(txt);
            string starTime = "";

            string[] msgList = txt.Split(' ');
            if (txt.Contains(':'))
            {
                foreach (var i in msgList)
                {
                    if (i.Contains(':') )
                    {
                        starTime = i;
                    }
                }

            }
            else //if (lp.ValidateLicensePlate(parserLicensePlate) && mp.ValidateMinutesMultiple30(mp.ValidateDigitAndGraterThanZero(parserMinutes)))
            {
                starTime = DateTime.Now.ToString("HH:mm");
            }

            return starTime;
        }


        public String ParserDayFromCheck(string txt)
        {
            txt = txt.Trim();
            String[] arrayTxt = txt.Split(' ');
            if (arrayTxt.Length <= 1)
            {
                return "";
            }
            else
            {
                return arrayTxt[0];
            }
        }

        public bool ValidateTime(string myTime)
        {
            bool auxReturn = false;
            if (myTime.Contains(':'))
            {
                string[] hourmin = myTime.Split(':');
                string hour = hourmin[0];
                int hours = Int32.Parse(hour);
                int minutes = Int32.Parse(hourmin[1]);
                if ((hours >= 10) && (hours <= 18) && (minutes>=0) && (minutes<60))
                {
                    return true;

                }
            }

            return auxReturn;
        }
        public bool ValidateDateNumberFromCheck(string MyMonth, string MyDay)
        {
            int ThisDay = Int32.Parse(DateTime.Now.ToString("dd"));
            int ThisMonth = Int32.Parse(DateTime.Now.ToString("MM"));
            return (Int32.Parse(MyMonth.Replace("0", "")) <= ThisMonth) && (Int32.Parse(MyDay.Replace("0", "")) <= ThisDay);
        }

        public bool ValidateNumberArrayFromCheck(string[] stringArray)
        {
            bool AreNumberOnly = true;
            int count = 0;
            while (AreNumberOnly && count < stringArray.Length)
            {
                AreNumberOnly = stringArray[count].All(char.IsDigit);
                count++;
            }
            return AreNumberOnly;
        }
        public bool ValidateDayFromCheck(string MyDay)
        {
            if (MyDay.Contains('/'))
            {
                string[] parserDay = MyDay.Split('/');
                return ValidateNumberArrayFromCheck(parserDay) && ValidateDateNumberFromCheck(parserDay[1], parserDay[0]);
            }
            else
            {
                return false;
            }
        }

        public string FormatDayFromCheck(string MyDate)
        {
            string[] formatDay = MyDate.Split('/');
            return formatDay[0] + "-" + formatDay[1];
        }

        public string GetTimeFromCheck(string myDate)
        {
            string parserTime = ParserTimeFromCheck(myDate);
            if (ValidateTime(parserTime))
            {
                return parserTime;
            }
            throw new InvalidTextCheckException();

        }

        public string GetTimeFromTxt(string myTime)
        {
            string parserTime = ParserTimeFromTxt(myTime);
            if (ValidateTime(parserTime))
            {
                return parserTime;
            }
            throw new InvalidTextException();
        }

        public string GetDayFromCheck(string myDay)
        {
            string parserDay = ParserDayFromCheck(myDay);
            if (ValidateDayFromCheck(parserDay))
            {
                return FormatDayFromCheck(parserDay);
            }
            throw new InvalidTextCheckException();
        }
    }
}



