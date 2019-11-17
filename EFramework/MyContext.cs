using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingBusinessLogic;

namespace EFramework
{
    public class MyContext : DbContext
    {
        
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        public MyContext() : base("name=MyContext")
        {
        }
    }
}
