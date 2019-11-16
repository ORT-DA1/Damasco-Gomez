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
        private MyContext context;

        public DataAccess()
        {
            context = new MyContext();
        }

        public void InsertAccount(Account account)
        {
            context.Accounts.Add(account);
            context.SaveChanges();
        }

        public Account FindByNum(string num)
        {
            Account myA = context.Accounts.Where(b => b.Number == num).FirstOrDefault();            
            return myA;
        }

        public void DisposeMyContext()
        {
            context.Dispose();
        }
    }
}
