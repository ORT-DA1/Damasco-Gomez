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

        public Account FindByNum(string num)
        {
            Account myA = Context.Accounts.Where(b => b.Number == num).FirstOrDefault();            
            return myA;
        }

        public void DisposeMyContext()
        {
            Context.Dispose();
        }
    }
}
