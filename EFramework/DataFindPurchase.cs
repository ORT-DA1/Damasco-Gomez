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
            
            if (purchases.Count()==0)
            {
                throw new NotPurchaseFound();
            } 
            else
            {
                foreach (var purchase in purchases)
                {
                    myA.Add(purchase);
                }
                return myA;
            }
            
        }

        public List<Purchase> FindPurchaseBetweenDate(string initDay, string finDay, string initHour, string finHour)
        {
            List<Purchase> pur = new List<Purchase>();
            CompareValues compareValues = new CompareValues();
            var purchases = Context.Purchases;
            foreach (var purchase in purchases)
            {
                if (compareValues.CompareDate(initDay, finDay, purchase.MyDay) &&
                        compareValues.CompareHours(initHour, finHour, purchase.MyInitHour) &&
                                compareValues.CompareHours(initHour, finHour, purchase.MyFinHour)) 
                pur.Add(purchase);
            }
            if (pur.Count == 0)
            {
                throw new NoPurchasewithDate();
            }
            else
            {
                return pur;
            }

        }

    }
}
