using Contracts;
using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic
{
    public class PurchaseArgentina : Purchase
    {


        public PurchaseArgentina()
        {
        }
        public PurchaseArgentina(string msg, AccountArgentina myA)
        {
            try
            {
                DateParser dateParser = new DateParser();
                string startTime = dateParser.GetTimeFromTxt(msg);
                MinuteParserArgentina minuteParser = new MinuteParserArgentina();
                LicensePlateParser myParserLicense = new LicensePlateParser();
                string licensePlate = myParserLicense.GetLicensePlate(msg);

                string finishTime = AddMinHour(minuteParser.GetCantMinutes(msg), startTime);
                
                MyAccount = myA;
                MyLicensePlate = licensePlate;
                MyDay = MyDay;
                MyInitHour = startTime;
                MyFinHour = finishTime;
            }
            catch (LogicException e)
            {
                throw new InvalidTextExceptionArgentina();
            }
        }





    }
}
