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

        const string formatNumUruguay = "098 876 898 or 98443256";
        const string formatNumArgentina = "123-456-78 or 1234567";

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
        
        public void AddAmountBalanceUru(string number, string balance)
        {            
            Account myAccount = new AccountUruguay();
            number = myAccount.ValidateAndFormat(number, formatNumUruguay);
            myAccount = dataFindAccount.FindAccountByNumber(number);
            myAccount.AddBalance(balance);
            dataAccessAccount.Update();

        }
        public void AddAmountBalanceArg(string number, string balance)
        {
            Account myAccount = new AccountArgentina();
            number = myAccount.ValidateAndFormat(number, formatNumArgentina);
            myAccount = dataFindAccount.FindAccountByNumber(number);
            myAccount.AddBalance(balance);
        }

    }
}
