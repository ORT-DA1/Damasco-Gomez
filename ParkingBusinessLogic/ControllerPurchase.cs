using ContractDataBase;
using ParkingBusinessLogic.Exceptions;
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

        public IDataAccess<Purchase> dataAccessPurchase { get; set; }
        public IDataAccess<Account> dataAccessAccount { get; set; }
        public IFindAccount<Account> dataFindAccount { get; set; }
        public IFindPurchase<Purchase> dataFindPurchase { get; set; }

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
        public Purchase RegisterPurchaseUru(string txtUru, string num)
        {
            Account account = dataFindAccount.FindAccountByNumber(num);
            Purchase purchase = new PurchaseUruguay(txtUru, account);
            dataAccessPurchase.Insert(purchase);
            return purchase;
        }
        public Purchase RegisterPurchaseArg(string txtArg, string num)
        {
            Account account = dataFindAccount.FindAccountByNumber(num);
            Purchase purchase = new PurchaseArgentina(txtArg, account);
            dataAccessPurchase.Insert(purchase);
            return purchase;
        }
        public void ChangeValueMinuteUru(int newValue)
        {
            valueOfMinuteUru.ChangeValue(newValue);
        }
        public void ChangeValueMinuteArg(int newValue)
        {
            valueOfMinuteArg.ChangeValue(newValue);
        }
        public void BuyParkingPurchaseUru(string msg, string num)
        {
            string formatNum = "098 898 987";
            Account myA = new AccountUruguay();
            myA = dataFindAccount.FindAccountByNumber(myA.ValidateAndFormat(num, formatNum));
            if (myA.Equals(null))
            {
                throw new NotAccountException();
            }
            Purchase  myP = RegisterPurchaseUru(msg,num);
            FindAndDiscount(myA, myP);
        }
        public void BuyParkingPurchaseArg(string msg, string num)
        {
            string formatNum = "123-456-78";
            Account myA = new AccountArgentina();
            myA = dataFindAccount.FindAccountByNumber(myA.ValidateAndFormat(num, formatNum));
            if (myA.Equals(null))
            {
                throw new NotAccountException();
            }
            Purchase myP = RegisterPurchaseArg(msg, num);
            FindAndDiscount(myA, myP);            
        }

        private void FindAndDiscount(Account account, Purchase purchase)
        {
            int amountToDiscont = FindAmountFromPurchase(purchase);
            account.DiscountBalance(amountToDiscont);
        }

        private int FindAmountFromPurchase(Purchase purchase)
        {
            MinuteParser minuteParser = new MinuteParserUruguay();
            int cantMinutes = minuteParser.CalculateCantMinutesFromPurchase(purchase.MyInitHour, purchase.MyFinHour);
            int amountToDiscont = valueOfMinuteUru.TotalPrice(cantMinutes);
            return amountToDiscont;
        }


    }
}
