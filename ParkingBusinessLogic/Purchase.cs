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
                myLicensePlate = value;
            }
        }
        public Account MyAccount
        {
            get
            {
                return myAccount;
            }
            private set
            {
                myAccount = value;
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
                myInitHour = value;                             
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
                myFinHour = value;
                
            }
        }
        public Purchase() {


        }
        public Purchase(string msg, Account myA)
        {
            string startTime = ParseStarTime(msg);
            MinuteParser myTool = new MinuteParser();
            LicensePlateParser myParserLicense = new LicensePlateParser();
            string licensePlate = myParserLicense.GetLicensePlate(msg);


            string finishTime = AddMinHour(  myTool.GetCantMinutes(msg) , (startTime));

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



        public string ParseStarTime(String msg)
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
