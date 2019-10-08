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

                Console.WriteLine("antes de la exep");
                throw new NotAccountException();

            }
            else
            {
              
                MinuteParser minuteParser = new MinuteParser();
                int cantMinutes = minuteParser.GetCantMinutes(msg);
                ValueMinute valueMinute = new ValueMinute();
                int amountToDiscont=valueMinute.TotalPrice(cantMinutes);
                myAccount.DiscountBalance(amountToDiscont);
                Purchase newPurchase = new Purchase(msg,myAccount);
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

            Purchase auxPurchase = new Purchase();

            //String formattedLP = FormatLicensePlate(licensePlate);
            //String day = FormatDay(dateTime);
            //String hour = FormatHour(dateTime);

            //bool result = false;
            //foreach (Purchase element in Purchases)
            //{

            //if (element.MyLicensePlate == formattedLP)
            //{
            //if (element.MyDay== day) && (element.MyInitHour== hour)
            //{
            // result = true;

            // }
            //}
            //}
            //return result;
            return true;

        }
    }

    
}
