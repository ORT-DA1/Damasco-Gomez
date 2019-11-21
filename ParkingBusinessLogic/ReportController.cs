using ContractDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic
{
    public class ReportController
    {
        private IFindPurchase<Purchase> DataFindPurchase { get; set; }

        public ReportController(IFindPurchase<Purchase> findPurchase)
        {
            DataFindPurchase = findPurchase;
        }

        public List<Purchase> FindPurchasesInDates (string initDay, string finDay, string initHour , string finHour)
        {
            return DataFindPurchase.FindPurchaseBetweenDate(initDay, finDay, initHour, finHour);
        }

        public List<Purchase> FindPurchasesByLicensePlate (string license)
        {
            return DataFindPurchase.FindPurchaseByLicense(license);

        }

        
    }
    
}
