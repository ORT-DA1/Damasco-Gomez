using ContractDataBase;
using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ParkingBusinessLogic
{
    public class ControllerAccount
    {
        public IDataAccessAccount<Account> dataAccessAccount { get; set; }

        public ControllerAccount()
        {
            
        }
        public bool RegisterAccount(Account account)
        {
            dataAccessAccount.InsertAccount(account);
            return true;

        }

        public Account FindAccountByNum(string num)
        {
            Account myA = dataAccessAccount.FindAccountByNumber(num);
            return myA;
        }
        
    }
}
