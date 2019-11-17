using ParkingBusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFramework
{
    public class DataAccess
    {
        public MyContext Context { get; private set; }

        public DataAccess()
        {
            Context = new MyContext();
        }

        public void InsertAccount(Account account)
        {
            Context.Accounts.Add(account);
            Context.SaveChanges();
        }

        public void InsertPurchase(Purchase purchase)
        {
            Context.Purchases.Add(purchase);
            Context.SaveChanges();
        }

        public Account FindAccountByNum(string num)
        {
            Account myA = Context.Accounts.Where(b => b.Number == num).FirstOrDefault();            
            return myA;
        }

        public List<Purchase> FindPurchaseByLicense(string license)
        {
            List<Purchase> myA = new List<Purchase>();
            var purchases = Context.Purchases.Where(b => b.MyLicensePlate == license );
            foreach(var purchase in purchases)
            {
                myA.Add(purchase);
            }
            return myA;
        }

        public void DisposeMyContext()
        {
            Context.Dispose();
        }
    }
}
