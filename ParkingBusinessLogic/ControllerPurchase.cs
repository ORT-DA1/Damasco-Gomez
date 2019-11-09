using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic
{
    public class ControllerPurchase
    {
        private ValueMinute valueOfMinuteUru;
        private ValueMinute valueOfMinuteArg;

        public ControllerPurchase()
        {

        }
        public bool RegisterPurchase(Purchase purchase)
        {
            //Purchases.Add(purchase);
            return true;

        }
        public int BuyParkingPurchaseUru(string msg, AccountUruguay myAccount)
        {
            Purchase newPurchase = new PurchaseUruguay(msg, myAccount);
            MinuteParser minuteParser = new MinuteParserUruguay();
            int cantMinutes = minuteParser.CalculateCantMinutesFromPurchase(newPurchase.MyInitHour, newPurchase.MyFinHour);
            int amountToDiscont = valueOfMinuteUru.TotalPrice(cantMinutes);
            myAccount.DiscountBalance(amountToDiscont);
            RegisterPurchase(newPurchase);
            return amountToDiscont;
        }
    }
}
