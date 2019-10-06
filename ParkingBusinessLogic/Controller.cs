using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ParkingBusinessLogic
{
    public class Controller
    {
        public List<Account> Accounts ;

        public List<Purchase> Purchases;

        public ValueMinute ValueOfMinute;

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

        public void ChageValueMinute(int value)
        {
            ValueOfMinute.ChangeValue(value);
        }
    }

    
}
