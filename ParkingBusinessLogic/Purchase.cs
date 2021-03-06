﻿using System;

namespace ParkingBusinessLogic
{
    public class Purchase
    {
        Account myAccount;
        string myLicensePlate;
        string myDay;
        string myInitHour;
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
        public Purchase()
        {
        }
        public Purchase(string msg, Account myA)
        {
            DateParser dateParser = new DateParser();
            string startTime = dateParser.GetTimeFromTxt(msg);
            MinuteParser minuteParser = new MinuteParser();
            LicensePlateParser myParserLicense = new LicensePlateParser();
            string licensePlate = myParserLicense.GetLicensePlate(msg);


            string finishTime = AddMinHour(minuteParser.GetCantMinutes(msg), startTime);

            myAccount = myA;
            MyLicensePlate = licensePlate;
            MyDay = MyDay;
            MyInitHour = startTime;
            MyFinHour = finishTime;
        }

        public string AddMinHour(int cantMin, string startTime)
        {
            double cantAddHour = ((double)cantMin / 60);
            DateTime addedHours = Convert.ToDateTime(startTime);
            addedHours = addedHours.AddHours(cantAddHour);
            if (OutOf18Hours(addedHours.ToString("HH:mm")))
            {
                return "18:00";
            }

            return addedHours.ToString("HH:mm");
        }

        public bool OutOf18Hours(string timeFinish)
        {
            string[] parserTime = timeFinish.Split(':');
            return ((Int32.Parse(parserTime[0]) > 18) || ((Int32.Parse(parserTime[0]) == 18) && (Int32.Parse(parserTime[1]) > 0)));

        }
        public bool ContainValues(string licensePlate, string date, string initTime)
        {
            bool result = false;
            if (MyLicensePlate == licensePlate)
            {
                if ((MyDay == date) && CompareHours( MyInitHour, MyFinHour, initTime))
                {
                    result = true;

                }
            }
            return result;
        }


        public bool CompareHours(string initHour, string finHour,  string compareHour)
        {
            string[] parserFin = finHour.Split(':');
            string[] parserIni = initHour.Split(':');
            string[] parseCompare = compareHour.Split(':');
            bool betweenHours = Int32.Parse(parserFin[0]) > Int32.Parse(parseCompare[0]) && Int32.Parse(parserIni[0]) < Int32.Parse(parseCompare[0]);
            bool sameHourInit = Int32.Parse(parserIni[0]) == Int32.Parse(parseCompare[0]) && Int32.Parse(parserIni[1]) <= Int32.Parse(parseCompare[1]);
            bool sameHourFinit = Int32.Parse(parserFin[0]) == Int32.Parse(parseCompare[0]) && Int32.Parse(parserFin[1]) > Int32.Parse(parseCompare[1]);
            return betweenHours || sameHourInit || sameHourFinit;
        }

        public override bool Equals(Object obj)
        {
            Purchase otherPurchase = (Purchase)obj;
            return (otherPurchase.MyLicensePlate == this.MyLicensePlate) &&
                (otherPurchase.MyInitHour == this.MyInitHour) && (otherPurchase.MyFinHour == this.MyFinHour);
        }


    }
}
