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
        public MyContext() : base("name=MyContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Purchase> Purchases { get; set; }
    }
}
