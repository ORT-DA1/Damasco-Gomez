using ContractDataBase;
using ParkingBusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFramework
{
    public class DataFindAccount: IFindAccount<Account>
    {
        public MyContext Context { get; set; }

        public DataFindAccount(MyContext context)
        {
            Context = context;
        }
        public void DisposeMyContext()
        {
            Context.Dispose();
        }

        public Account FindAccountByNumber(string num)
        {
            Account myA = Context.Accounts.Where(b => b.Number == num).FirstOrDefault();
            return myA;
        }
    }
}
