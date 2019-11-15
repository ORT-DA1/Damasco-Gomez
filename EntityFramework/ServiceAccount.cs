using ParkingBusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class ServiceAccount
    {
       
        private MyContext myContext;
        public ServiceAccount()
        {
        }
       

        public Account GetAccountByNumber(string numero)
        {
            Guid id = new Guid();
            return myContext.Find(id);
        }
    }
}
