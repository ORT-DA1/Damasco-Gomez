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

        public void InitLists()
        {
           Accounts = new List<Account>();
           Purchases = new List<Purchase>();

       }
       




        public bool RegisterAccount(String num, int balance)
        {   
            
            Account account = new Account(num, balance);
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
