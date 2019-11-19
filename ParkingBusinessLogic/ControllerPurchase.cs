using ContractDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic
{
    public class ControllerPurchase
    {
        public ValueMinute valueOfMinuteUru { get; set; }
        public ValueMinute valueOfMinuteArg { get; set; }

        public IDataAccess<Purchase> dataAccessPurchase;
        public IDataAccess<Account> dataAccessAccount;
        public IFindAccount<Account> dataFindAccount;
        public IFindPurchase<Purchase> dataFindPurchase;

        public ControllerPurchase(IDataAccess<Purchase> accessPurchase, IDataAccess<Account> accessAccount, 
            IFindAccount<Account> findAccount, IFindPurchase<Purchase> findPurchase)
        {
            dataAccessPurchase = accessPurchase;
            dataAccessAccount = accessAccount;
            dataFindAccount = findAccount;
            dataFindPurchase = findPurchase;
            valueOfMinuteUru = new ValueMinute();
            valueOfMinuteArg = new ValueMinute();
        }
        public bool RegisterPurchase(Purchase purchase)
        {
            dataAccessPurchase.Insert(purchase);
            return true;
        }
        public void ChangeValueMinuteUru(int newValue)
        {
            valueOfMinuteUru.ChangeValue(newValue);
        }
        public void ChangeValueMinuteArg(int newValue)
        {
            valueOfMinuteArg.ChangeValue(newValue);
        }
        public void BuyParkingPurchaseUru(string msg, Account myAccount)
        {
            Account myA = dataFindAccount.FindAccountByNumber(myAccount.Number);
            Purchase myP = new PurchaseUruguay(msg, myA);
            FindAndDiscount(myA, myP);
            RegisterPurchase(myP);
        }
        public void BuyParkingPurchaseArg(string msg, Account myAccount)
        {
            Account myA = dataFindAccount.FindAccountByNumber(myAccount.Number);
            Purchase myP = new PurchaseArgentina(msg, myA);
            FindAndDiscount(myA, myP);
            RegisterPurchase(myP);
        }

        public void FindAndDiscount(Account account, Purchase purchase)
        {
            int amountToDiscont = FindAmountFromPurchase(purchase);
            account.DiscountBalance(amountToDiscont);
        }

        public int FindAmountFromPurchase(Purchase purchase)
        {
            MinuteParser minuteParser = new MinuteParserUruguay();
            int cantMinutes = minuteParser.CalculateCantMinutesFromPurchase(purchase.MyInitHour, purchase.MyFinHour);
            int amountToDiscont = valueOfMinuteUru.TotalPrice(cantMinutes);
            return amountToDiscont;
        }


    }
}
