using ContractDataBase;
using ParkingBusinessLogic;
using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFramework
{
    public class DataAccessAccount : IDataAccess<Account>//, IFindList<Purchase>
    {
        const string problemConnection = "the data base is not connected";
        const string sameAccount = "you have an account with that number";
        public MyContext Context { get; private set; }

        public DataAccessAccount(MyContext context)
        {
            Context = context;
        }

        public void Insert(Account account)
        {
            try
            {
                Context.Accounts.Add(account);
                Context.SaveChanges();
            }
            catch (DbException e)
            {
                throw new DataBaseException(problemConnection); // error d conexion
            }
            catch (DbUpdateException e)
            {
                throw new DataBaseException(sameAccount); //has account with number
            }
        }

        public void DisposeMyContext()
        {
            Context.Dispose();
        }
        public void Update()
        {
            Context.SaveChanges();
        }
        public void DeleteDataBase()
        {
            Context.Database.ExecuteSqlCommand("delete from Purchases;");
            Context.Database.ExecuteSqlCommand("delete from Accounts;");

        }

        public List<Account> AllData()
        {
            var listAccount = Context.Accounts;
            List<Account> myAccounts = new List<Account>();
            foreach(var a in listAccount)
            {
                myAccounts.Add(a);
            }
            return myAccounts;
        }
    }
}
