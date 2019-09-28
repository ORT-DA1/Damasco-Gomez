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
                if (ValidateLicensePlate(myLicensePlate))
                {
                    MyLicensePlate = myLicensePlate;
                }
                else
                {
                    throw new InvalidTextException();
                }
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
                MyDay = DateTime.Now.ToString("dd-MM");
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
                if (ValidateTime(myInitHour))
                {
                    MyInitHour = myInitHour;
                }
                else
                {
                    throw new InvalidTextException();
                }
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
                if (ValidateTime(myFinHour))
                {
                    MyFinHour = myFinHour;
                }
                else
                {
                    throw new InvalidTextException();
                }
            }
        }
        public Purchase(string msg, Account myA)
        {
            //string[] msgList = msg.Split(' ');
            string licensePlate = ParseLicensePlate(msg);            
            string startTime = ParseStarTime(msg);
            Tools myTool = new Tools();
            string finishTime = AddMinHour(  myTool.BreakDownCantMinutes(msg) , startTime);

            myAccount = myA ;
            myLicensePlate = licensePlate;
            myDay = MyDay;
            myInitHour = startTime;
            myFinHour = finishTime;
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

        public bool ValidateTime(string startTime)
        {            
            if (!startTime.Equals("") && startTime.Contains(':'))
            {
                string[] hourmin = startTime.Split(':');
                string hour = hourmin[0];
                int hours = Int32.Parse(hour);
                if ((hours >= 10) && (hours <= 18))
                {
                    return true;

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


        private bool ValidateLicensePlate(string licensePlate)
        {
            if (!licensePlate.Equals("") && Regex.IsMatch(licensePlate, @"^[a-zA-Z]{3}\d{4}$"))
            {
                return true;
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
            if (msgList.Length > 2)
            {
                
                if (msgList.Length == 3)
                {
                    starTime = msgList[2];

                }else if (msgList.Length == 4)
                {
                    starTime = msgList[2];
                }
            }
            else
            {
                starTime = DateTime.Now.ToString("hh:mm");
            }
            return starTime;
        }
    }
}
