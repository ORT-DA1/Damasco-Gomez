using ContractDataBase;
using ParkingBusinessLogic;
using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core;
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
<<<<<<< HEAD
           
                Context.Accounts.Add(account);
                Context.SaveChanges();
=======
            try
            {
                Context.Accounts.Add(account);
                Context.SaveChanges();
            }
            catch (DbException e)
            {
                throw new DataBaseException(problemConnection); // error d conexion
            }
            catch (EntityException e)
            {
                throw new DataBaseException(sameAccount); //has account with number
            }
>>>>>>> dc3158536e84daa921f14383383fadaf91928ac9
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
