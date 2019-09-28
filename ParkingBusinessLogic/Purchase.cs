using ParkingBusinessLogic.Exceptions;
using ParkingBusinessLogic.Tools;
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
                if (ValidateFormat(licensePlate))
                {
                    licensePlate = Format(licensePlate);
                }
                else
                {
                    throw new InvalidNumberException();
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
                myDay = DateTime.Now;
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
                if (ValidateFormat(value))
                {
                    number = Format(value);
                }
                else
                {
                    throw new InvalidNumberException();
                }
            }
        }
        public Purchase(string msg, Account myA)
        {
            //string[] msgList = msg.Split(' ');
            string licensePlate = BreakDownLicensePlate(msg);
            
            string startTime = BreakDownStarTime(msg);
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

        public bool ValidateMsg(string msg)
        {

            //string[] msgList = msg.Split(' ');
            string licensePlate = BreakDownLicensePlate(msg);
            string cantMinutes = BreakDownCantMinutes(msg);
            string startTime = BreakDownStarTime(msg);



            if (ValidateLicensePlate(licensePlate) && ValidateMinutesMultiple30(cantMinutes))
            {
                startTime = ValidateStartTime(startTime);
                return true;
            }
            else
            {
                return false;
            }
        }





        public string ValidateStartTime(string startTime)
        {
            if (!startTime.Equals("") && startTime.Contains(':'))
            {


                string[] hourmin = startTime.Split(':');
                string hour = hourmin[0];
                string min = hourmin[1];
                int hours = Int32.Parse(hour);
                int mins = Int32.Parse(min);
                if ((hours >= 10) && (hours <= 18))
                {
                    return startTime;

                }
                else { throw new InvalidTextException(); }


            }
            else
            {
                DateTime time = DateTime.Now;
                return time.ToString("h:mm");
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


        public string BreakDownLicensePlate(string msg)
        {

            string licensePlate = ParseLicensePlate(msg);
            ValidateLicensePlate(licensePlate);
            return licensePlate;




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



        public string BreakDownStarTime(string msg)
        {

            string starTime = ParseStarTime(msg);
            ValidateStartTime(starTime);
            return starTime;


        }
        public string ParseStarTime(string msg)
        {
            string starTime = "";
            string[] msgList = msg.Split(' ');
            if (msgList.Length >= 2)
            {
                if (msgList[0].Length == 3)
                {

                    if (msgList.Length > 3)
                    {
                        starTime = msgList[3];
                    }

                }
                else
                {
                    if (msgList.Length > 2)
                    {

                        starTime = msgList[2];
                    }

                }
            }
            return starTime;


        }
    }
}
