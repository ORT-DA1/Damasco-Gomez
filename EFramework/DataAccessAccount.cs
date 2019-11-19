using ContractDataBase;
using ParkingBusinessLogic;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFramework
{
    public class DataAccessAccount : IDataAccessAccount<Account>//, IFindList<Purchase>
    {
        public MyContext Context { get; private set; }

        public DataAccessAccount()
        {
            Context = new MyContext();
        }

        public void InsertAccount(Account account)
        {
           
                Context.Accounts.Add(account);
                Context.SaveChanges();
        }

        public void DisposeMyContext()
        {
            Context.Dispose();
        }

        public Account FindAccountByNumber(string num)
        {
            Account myA = Context.Accounts.Where(b => b.Number == num).FirstOrDefault();
            return myA;
        }
    }
}
