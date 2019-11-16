using Contracts;
using ParkingBusinessLogic.Exceptions;
using System;

namespace ParkingBusinessLogic
{
    public class PurchaseUruguay : Purchase
    {
       
        public PurchaseUruguay()
        {
        }
        public PurchaseUruguay(Guid id, string msg, AccountUruguay myA)
        {
            try
            {
                Id = id;
                DateParser dateParser = new DateParser();
                string startTime = dateParser.GetTimeFromTxt(msg);
                MinuteParserUruguay minuteParser = new MinuteParserUruguay();
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
                throw new InvalidTextExceptionUruguay();

            }
           
        }
    }
}
