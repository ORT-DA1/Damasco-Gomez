﻿using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
            private set
            {
                Accounts = value;
            }
        }

        public List<Purchase> Purchases
        {
            get
            {
                return purchases;
            }
            private set
            {
                Purchases = value;
            }
        }
        public ValueMinute ValueOfMinute
        {
            get
            {
                return valueOfMinute;
            }
            private set
            {
                valueOfMinute = value;
            }
        }
        public Controller()
        {
            accounts = new List<Account>();
            purchases = new List<Purchase>();
            valueOfMinute = new ValueMinute();
        }


        public bool isAccountEmpty(Account account)
        {
            return account.AccountEmpty();

        }

        public bool RegisterAccount(Account account) 
        {               
            Accounts.Add(account);
            return true;
      
        }

        public Account FindAccount(String text)
        { 
        
            Account myAccount = new Account();
            Account auxiliar = new Account(text,0);
            foreach (Account element in Accounts)
            {
                if (element.Number == auxiliar.Number)
                {
                    myAccount= element;

                }                                            
            }
            return myAccount;
        }
        public Purchase FindPurchase(Account myAccount) {

            Purchase myPurchase= new Purchase() ;
            foreach (Purchase element in Purchases) {

                if (element.MyAccount == myAccount) {
                    myPurchase = element;
                }
            }
            return myPurchase;

        }


        public void BuyParking(String num, String msg)
        {

            Account myAccount = FindAccount(num);
            if (isAccountEmpty(myAccount)) {

                throw new NotAccountException();

            }
            else
            {
                Purchase newPurchase = new Purchase(msg, myAccount);
                MinuteParser minuteParser = new MinuteParser();
                ValueMinute valueMinute = new ValueMinute();
                int cantMinutes = minuteParser.CalculateCantMinutesFromPurchase(newPurchase.MyInitHour, newPurchase.MyFinHour);
                int amountToDiscont=valueMinute.TotalPrice(cantMinutes);               
                myAccount.DiscountBalance(amountToDiscont);                
                Purchases.Add(newPurchase);




            }
         }

        public void ChageValueMinute(int value)
        {
            ValueOfMinute.ChangeValue(value);
        }

        public void AddBalanceInAccount(Account MyAccount, int value)
        {
            MyAccount.AddBalance(value);
        }
        public bool ChekPurchase(String licensePlate, String dateTime)
        {

           
            LicensePlateParser licensePlateParser = new LicensePlateParser();
            string lp= licensePlateParser.GetLicensePlate(licensePlate);
            DateParser dateParse = new DateParser();
            string hour = dateParse.GetTimeFromCheck(dateTime);
            string day = dateParse.GetDayFromCheck(dateTime);
            Purchase purchase = new Purchase(lp,day,hour);
            bool isActivepurchase =  FindPurchase(purchase);
            return isActivepurchase;





        }
        public bool FindPurchase(Purchase purchase)
        {
            bool result = false;
            foreach (Purchase element in Purchases)
            {

                if (element.MyLicensePlate == purchase.MyLicensePlate)
                {
                    if ((element.MyDay == purchase.MyDay) && (element.MyInitHour == purchase.MyInitHour))
                    {
                        result = true;

                    }
                }
            }
            return result;

        }

        public override string ToString()
        {
            foreach (Account s in Accounts)
            {
                Console.WriteLine(s);
            }
            foreach (Purchase t in Purchases)
            {
                Console.WriteLine(t);
            }
            return "Controller was. " ;
        }

    }

    
}
