using ContractDataBase;
using EFramework;
using ParkingBusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resport
{
    public class ReportClass
    {
        IDataAccess<Purchase> dataAccessPurchase;
        IDataAccess<Account> dataAccessAccount;
        IFindPurchase<Purchase> dataFindPurchase;
        IFindAccount<Account> dataFindAccount;

        public ReportClass(MyContext myContext)
        {

        }
    }
}
