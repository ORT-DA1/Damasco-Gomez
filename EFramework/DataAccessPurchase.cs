using ContractDataBase;
using ParkingBusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFramework
{
    public class DataAccessPurchase : IDataAccessPurchase<Purchase>
    {
        public MyContext Context { get; private set; }

        public DataAccessPurchase()
        {
            Context = new MyContext();
        }
        public void DisposeMyContext()
        {
            Context.Dispose();
        }

        public List<Purchase> FindPurchaseByLicense(string license)
        {
            List<Purchase> myA = new List<Purchase>();
            var purchases = Context.Purchases.Where(b => b.MyLicensePlate == license);
            foreach (var purchase in purchases)
            {
                myA.Add(purchase);
            }
            return myA;
        }

        public void InsertPurchase(Purchase purchase)
        {
            Context.Purchases.Add(purchase);
            Context.SaveChanges();
        }
    }
}
