using ParkingBusinessLogic.Exceptions;
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
            foreach (Account element in Accounts)
            {
                if (element.Number == text)
                {
                    myAccount= element;

                }                                            
            }
            return myAccount;
        }
        public Purchase FindPurchase(String licensePlate) {

            Purchase myPurchase= new Purchase() ;
            foreach (Purchase element in Purchases) {

                if (element.MyLicensePlate== licensePlate) {
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
    }

    
}
