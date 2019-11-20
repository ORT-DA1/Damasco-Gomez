using ContractDataBase;
using ParkingBusinessLogic;
using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFramework
{
    public class DataFindPurchase : IFindPurchase<Purchase>
    {
        public MyContext Context { get; set; }

        public DataFindPurchase(MyContext context)
        {
            Context = context;
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
            if (myA == null)
            {
                throw new NotPurchaseWithLicense();
            }
            return myA;
        }
    }
}
