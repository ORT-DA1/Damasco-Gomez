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
    public class DataAccessPurchase : IDataAccess<Purchase>
    {
        const string problemConnection = "the data base is not connected";
        const string sameAccount = "you have an account with that number";

        public MyContext Context { get;  set; }

        public DataAccessPurchase(MyContext context)
        {
            Context = context;
        }
        public void DisposeMyContext()
        {
            Context.Dispose();
        }

        public void Insert(Purchase purchase)
        {
            try
            {

                Context.Purchases.Add(purchase);
                Context.SaveChanges();
            }
            catch (DbException e)
            {
                throw new DataBaseException(sameAccount); // error d conexion
            }
            catch (UpdateException e)
            {
                throw new DataBaseException(sameAccount); //has account with number
            }
            catch (DbUpdateException e)
            {
                throw new DataBaseException(sameAccount);
            }
        }
        public void DeleteDataBase()
        {
            Context.Database.ExecuteSqlCommand("delete from Purchases;");
            Context.Database.ExecuteSqlCommand("delete from Accounts;");

        }
        public void Update()
        {
            Context.SaveChanges();
        }

    }
}
