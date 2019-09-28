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
        public bool RegisterAccount(String num, int balance)
        {
            Account account = new Account(num, balance);
            return true;

        }

    }

    
}
