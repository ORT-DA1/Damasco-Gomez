using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;


namespace ParkingBusinessLogic
{
    public class Controller
    {
        private List<Account> accounts;
        private List<Purchase> purchases;
        public ValueMinute valueOfMinute;

        public List<Account> Accounts
        {
            get
            {
                return accounts;
            }
        }

        public List<Purchase> Purchases
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
            purchases = new List<Purchase>();
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
        public bool RegisterPurchase(Purchase purchase)
        {
            Purchases.Add(purchase);
            return true;

        }

        public Account FindAccount(string text)
        {

            Account myAccount = new Account();
            Account auxiliar = new Account(text, 0);
            foreach (Account element in Accounts)
            {
                if (element.Number == auxiliar.Number)
                {
                    myAccount = element;

                }
            }
            return myAccount;
        }



        public void BuyParking(String num, String msg)

        {
            Account myAccount = FindAccount(num);
            if (IsAccountEmpty(myAccount))
            {
                throw new NotAccountException();
            }
            else
            {
                Purchase newPurchase = new Purchase(msg, myAccount);
                MinuteParser minuteParser = new MinuteParser();
                int cantMinutes = minuteParser.CalculateCantMinutesFromPurchase(newPurchase.MyInitHour, newPurchase.MyFinHour);
                int amountToDiscont = valueOfMinute.TotalPrice(cantMinutes);
                myAccount.DiscountBalance(amountToDiscont);
                RegisterPurchase(newPurchase);
            }
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
            foreach (Purchase element in Purchases)
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
