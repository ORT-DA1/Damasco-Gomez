using ContractDataBase;
using ParkingBusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFramework
{
    public class DataAccessPurchase : IDataAccess<Purchase>
    {
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
            Context.Purchases.Add(purchase);
            Context.SaveChanges();
        }
        public void DeleteDataBase()
        {
            Context.Database.ExecuteSqlCommand("delete from Purchases;");
            Context.Database.ExecuteSqlCommand("delete from Accounts;");

        }
    }
}
