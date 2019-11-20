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

        const string correctNumUruguay = "098 786 898 or 98 765 678";
        const string correctNumArgentina = "123-456-78 or 12345678";

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
            Account account = new AccountUruguay();
            num = account.ValidateAndFormat(num, correctNumUruguay);
            account = dataFindAccount.FindAccountByNumber(num);
            Purchase purchase = new PurchaseUruguay(txtUru, account);
            dataAccessPurchase.Insert(purchase);
            return purchase;
        }
        public Purchase RegisterPurchaseArg(string txtArg, string num)
        {

            Account account = new AccountArgentina();
            num = account.ValidateAndFormat(num,correctNumArgentina);
            account = dataFindAccount.FindAccountByNumber(num);
            Purchase purchase = new PurchaseArgentina(txtArg, account);
            dataAccessPurchase.Insert(purchase);
            return purchase;
        }
        public void ChangeValueMinuteUru(string newValue)
        {
            valueOfMinuteUru.ChangeValue(newValue);
        }
        public void ChangeValueMinuteArg(string newValue)
        {
            valueOfMinuteArg.ChangeValue(newValue);
        }
        public void BuyParkingPurchaseUru(string msg, string num)
        {
            string formatNum = "098 898 987";
            Account myA = new AccountUruguay();
            myA = dataFindAccount.FindAccountByNumber(myA.ValidateAndFormat(num, formatNum));
            
            Purchase  myP = RegisterPurchaseUru(msg,num);
            FindAndDiscount(myA, myP);
        }
        public void BuyParkingPurchaseArg(string msg, string num)
        {
            string formatNum = "123-456-78";
            Account myA = new AccountArgentina();
            myA = dataFindAccount.FindAccountByNumber(myA.ValidateAndFormat(num, formatNum));
            
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

        public bool ContainPurchaseInHour(string license , string txt)
        {
            
            LicensePlateParser newParserLicense = new LicensePlateParser();
            license = newParserLicense.FormatAndValidateLicensePlate(license);
            List<Purchase> purchaseWithLicense = dataFindPurchase.FindPurchaseByLicense(license);
            DateParser dateParser = new DateParser();
            string day = dateParser.GetDayFromCheck(txt);
            string time = dateParser.GetTimeFromCheck(txt);
            bool resul = false;
            bool resulOfPurchase = false;
            foreach (var purchase in purchaseWithLicense)
            {
                resulOfPurchase = (day == purchase.MyDay) &&
                    purchase.CompareHours(purchase.MyInitHour, purchase.MyFinHour, time);
                resul = resul || resulOfPurchase;
            }
            if (!resul)
            {
                throw new NoPurchasewithDate();

            }
            return resul;
            
        }

        public List<Purchase> ContainPurchase(string license, string initHour, string finHour, string day)
        {
            List<Purchase> itContains = new List<Purchase>();
            LicensePlateParser newParserLicense = new LicensePlateParser();
            license = newParserLicense.FormatAndValidateLicensePlate(license);
            initHour = initHour.Trim();
            finHour = finHour.Trim();
            List<Purchase> purchaseWithLicense = dataFindPurchase.FindPurchaseByLicense(license);
            foreach (var purchase in purchaseWithLicense)
            {
                if (purchase.MyInitHour == initHour && purchase.MyFinHour == finHour && purchase.MyDay==day)
                {
                    itContains.Add(purchase);
                }
            }
            return itContains;
        }


    }
}
