using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ParkingBusinessLogic
{
    public class Controller
    {
        private List<Account> accounts ;

        private List<Purchase> purchases;

        public ValueMinute ValueOfMinute;

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
        public void InitLists()
        {

            Accounts = new List<Account>();
            Purchases = new List<Purchase>();
            ValueOfMinute = new ValueMinute();
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

        public void BuyParking(String num, String msg)
        {

            Account myAccount = FindAccount(num);
            if (isAccountEmpty(myAccount)) {

                //throw new NotAccountException();

            }
            else
            {
                MinuteParser minuteParser = new MinuteParser();
                int cantMinutes = minuteParser.GetCantMinutes(msg);
                

            }
         }

        public void ChageValueMinute(int value)
        {
            ValueOfMinute.ChangeValue(value);
        }
    }

    
}
