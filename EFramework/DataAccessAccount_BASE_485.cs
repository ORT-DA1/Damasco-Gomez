using ContractDataBase;
using ParkingBusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFramework
{
    public class DataAccessAccount : IDataAccess<Account>//, IFindList<Purchase>
    {
        public MyContext Context { get; private set; }

        public DataAccessAccount(MyContext context)
        {
            Context = context;
        }

        public void Insert(Account account)
        {
            Context.Accounts.Add(account);
            Context.SaveChanges();
        }

        public void DisposeMyContext()
        {
            Context.Dispose();
        }

        public void DeleteDataBase()
        {
            Context.Database.ExecuteSqlCommand("delete from Purchases;");
            Context.Database.ExecuteSqlCommand("delete from Accounts;");

        }

    }
}
