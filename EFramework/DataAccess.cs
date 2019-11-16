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

        public void InsertAccount(Account account)
        {
            context = new MyContext();
            context.Accounts.Add(account);
            context.SaveChanges();
            context.Dispose();
        }
    }
}
