using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic
{
    public abstract class Purchase
    {
        public Guid Id { get; set; }
        public string MyLicensePlate { get; set; }       
        public Account MyAccount { get; set; }
        public string MyInitHour { get; set; }
        public string MyFinHour { get; set; }
        string myDay;
        public string MyDay
        {
            get
            {
                return myDay;
            }
             set
            {
                myDay = DateTime.Now.ToString("dd-MM");
            }
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
                if ((MyDay == date) && CompareHours(MyInitHour, MyFinHour, initTime))
                {
                    result = true;

                }
            }
            return result;
        }
        public bool CompareHours(string initHour, string finHour, string compareHour)
        {
            string[] parserFin = finHour.Split(':');
            string[] parserIni = initHour.Split(':');
            string[] parseCompare = compareHour.Split(':');
            bool betweenHours = Int32.Parse(parserFin[0]) > Int32.Parse(parseCompare[0]) && Int32.Parse(parserIni[0]) < Int32.Parse(parseCompare[0]);
            bool sameHourInit = Int32.Parse(parserIni[0]) == Int32.Parse(parseCompare[0]) && Int32.Parse(parserIni[1]) <= Int32.Parse(parseCompare[1]);
            bool sameHourFinit = Int32.Parse(parserFin[0]) == Int32.Parse(parseCompare[0]) && Int32.Parse(parserFin[1]) > Int32.Parse(parseCompare[1]);
            return betweenHours || sameHourInit || sameHourFinit;
        }
        public bool ContainsLicense(List<Purchase> obj, string license)
        {
            bool itContains = false;
            foreach(var purchase in obj)
            {
                itContains = itContains || purchase.MyLicensePlate == license;
            }
            return itContains;
        }
        public override bool Equals(Object obj)
        {
            Purchase otherPurchase = (Purchase)obj;
            return (otherPurchase.MyLicensePlate == this.MyLicensePlate) &&
                (otherPurchase.MyInitHour == this.MyInitHour) && (otherPurchase.MyFinHour == this.MyFinHour);
        }
    }
}
