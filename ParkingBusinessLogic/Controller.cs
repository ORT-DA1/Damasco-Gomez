using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;


namespace ParkingBusinessLogic
{
    public class Controller
    {
        private List<Account> accounts;
        private List<PurchaseUruguay> purchases;
        public ValueMinute valueOfMinute;

        public List<Account> Accounts
        {
            get
            {
                return accounts;
            }
        }

        public List<PurchaseUruguay> Purchases
        {
            get
            {
                return purchases;
            }
        }
        public ValueMinute ValueOfMinute
        {
            get
            {
                return valueOfMinute;
            }
        }
        public Controller()
        {
            accounts = new List<Account>();
            purchases = new List<PurchaseUruguay>();
            valueOfMinute = new ValueMinute();
        }


        public bool IsAccountEmpty(Account account)
        {
            return account.AccountEmpty();

        }

        public bool RegisterAccount(Account account)
        {
            Accounts.Add(account);
            return true;

        }
        public bool RegisterPurchase(PurchaseUruguay purchase)
        {
            Purchases.Add(purchase);
            return true;

        }
        /*
        public AccountUruguay FindAccount(string text)
        {

            AccountUruguay myAccount = new AccountUruguay();
            AccountUruguay auxiliar = new AccountUruguay(text, "0");
            foreach (AccountUruguay element in Accounts)
            {
                if (element.Number == auxiliar.Number)
                {
                    myAccount = element;

                }
            }
            return myAccount;
        }
        */


        public void BuyParking(String num, String msg)

        {/*
            AccountUruguay myAccount = FindAccount(num);
            if (IsAccountEmpty(myAccount))
            {
                throw new NotAccountException();
            }
            else
            {
                PurchaseUruguay newPurchase = new PurchaseUruguay(msg, myAccount);
                MinuteParserUruguay minuteParser = new MinuteParserUruguay();
                int cantMinutes = minuteParser.CalculateCantMinutesFromPurchase(newPurchase.MyInitHour, newPurchase.MyFinHour);
                int amountToDiscont = valueOfMinute.TotalPrice(cantMinutes);
                myAccount.DiscountBalance(amountToDiscont);
                RegisterPurchase(newPurchase);
            }
            */
        }

        public void ChageValueMinute(int value)
        {
            valueOfMinute.ChangeValue(value);
        }

        public void AddBalanceInAccount(Account MyAccount, int value)
        {
            MyAccount.AddBalance(value);
        }
        public bool ChekPurchase(String licensePlate, String dateTime)
        {
            LicensePlateParser licensePlateParser = new LicensePlateParser();
            string lp = licensePlateParser.FormatAndValidateLicensePlate(licensePlate);
            DateParser dateParse = new DateParser();
            string hour = dateParse.GetTimeFromCheck(dateTime);
            string day = dateParse.GetDayFromCheck(dateTime);
            bool isActivepurchase = FindPurchase(lp, day, hour);
            return isActivepurchase;
        }
        public bool FindPurchase(string licensePlate, string date, string initTime)
        {
            bool result = false;
            foreach (PurchaseUruguay element in Purchases)
            {
                if (element.ContainValues(licensePlate, date, initTime))
                {
                    result = true;
                }
            }
            return result;

        }



    }


}
