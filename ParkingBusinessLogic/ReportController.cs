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
        private IDataAccess<Purchase> DataAccessPurchase { get; set; }
        private IFindAccount<Account> DataFindAccount { get; set; }
        private IFindPurchase<Purchase> DataFindPurchase { get; set; }

        public ReportController( IDataAccess<Purchase> dataPurchase , IFindAccount<Account> findAccount, IFindPurchase<Purchase> findPurchase)
        {
            DataAccessPurchase = dataPurchase;
            DataFindAccount = findAccount;
            DataFindPurchase = findPurchase;
        }

        
    }
    
}
