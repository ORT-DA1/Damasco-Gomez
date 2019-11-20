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
        public IDataAccess<Account> dataAccessAccount { get; set; }
        public IFindAccount<Account> dataFindAccount { get; set; }

        public ControllerAccount(IDataAccess<Account> dataInsert, IFindAccount<Account> dataFind)
        {
            dataAccessAccount = dataInsert;
            dataFindAccount = dataFind;
        }
        public bool RegisterAccount(Account account)
        {
            dataAccessAccount.Insert(account);
            return true;

        }
        public Account FindAccountByNum(string num)
        {
            Account myA = dataFindAccount.FindAccountByNumber(num);
            return myA;
        }
        
        public void AddAmountBalance(string number, string balance)
        {
            Account myAccount = dataFindAccount.FindAccountByNumber(number);
            myAccount.AddBalance(balance);
        }

    }
}
