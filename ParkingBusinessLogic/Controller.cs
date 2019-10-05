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

        public void InitLists()
        {
           Accounts = new List<Account>();
           Purchases = new List<Purchase>();

       }

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


    }

    
}
