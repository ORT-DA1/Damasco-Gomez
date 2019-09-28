using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParkingBusinessLogic
{
    public class Purchase
    {
        Account myAccount;
        string myLicensePlate;
        string myDay;
        string myInitHour ;
        string myFinHour;
        public string MyLicensePlate
        {
            get
            {
                return myLicensePlate;
            }
            private set
            {
                myLicensePlate = ValidateLicensePlate(value);
            }
        }
        public string MyDay
        {
            get
            {
                return myDay;
            }
            private set
            {
                myDay = DateTime.Now.ToString("dd-MM");
            }
        }
        public string MyInitHour
        {
            get
            {
                return myInitHour;
            }
            private set
            {
                myInitHour = ValidateTime(value);                             
            }
        }
        public string MyFinHour
        {
            get
            {
                return myFinHour;
            }
            private set
            {
                myFinHour = ValidateTime(value);
                
            }
        }
        public Purchase(string msg, Account myA)
        {
            string licensePlate = ParseLicensePlate(msg);            
            string startTime = ParseStarTime(msg);
            Tools myTool = new Tools();


            string finishTime = AddMinHour(  myTool.BreakDownCantMinutes(msg) , ValidateTime(startTime));

            myAccount = myA ;
            MyLicensePlate = licensePlate;
            MyDay = MyDay;
            MyInitHour = startTime;
            MyFinHour = finishTime;
        }

        private string AddMinHour(int cantMin, string startTime)
        {
                string[] divStartTime = startTime.Split(':');
                int Hour = Convert.ToInt32(divStartTime[0]);
                int Min = Convert.ToInt32(divStartTime[1]);
                int cantAddHour = cantMin / 60;
                int cantAddMin = cantMin % 60;
                int finalHour = Hour + cantAddHour;
                int finalMin = Min + cantAddMin;
                return finalHour + ":" + finalMin;
            
        }

        public string ValidateTime(string startTime)
        {            
            if (!startTime.Equals("") && startTime.Contains(':'))
            {
                string[] hourmin = startTime.Split(':');
                string hour = hourmin[0];
                int hours = Int32.Parse(hour);
                if ((hours >= 10) && (hours <= 18))
                {
                    return startTime;

                }
                else
                {
                    throw new InvalidStartTimeException();
                }
            }
            else
            {
                throw new InvalidStartTimeException();
            }
        }


        private string ValidateLicensePlate(string licensePlate)
        {
            if (!licensePlate.Equals("") && Regex.IsMatch(licensePlate, @"^[a-zA-Z]{3}\d{4}$"))
            {
                return licensePlate;
            }
            else
            {
                throw new InvalidTextException();
            }
        }

        private string ParseLicensePlate(string msg)
        {
            string[] msgList = msg.Split(' ');
            string licensePlate = "";
            if (msgList.Length >= 2)
            {
                if (msgList[0].Length == 3)
                {
                    licensePlate = msgList[0] + msgList[1];
                }
                else
                {
                    licensePlate = msgList[0];
                }
            }
            return licensePlate;
        }

        public string ParseStarTime(string msg)
        {
            string starTime = "";
            string[] msgList = msg.Split(' ');
            if (msg.Contains(':'))
            {
                
                if (msgList.Length == 3)
                {
                    starTime = msgList[2];

                }else if (msgList.Length == 4)
                {
                    starTime = msgList[3];
                }
            }
            else
            {
                starTime = DateTime.Now.ToString("HH:mm");
            }
            return starTime;
        }
    }
}
