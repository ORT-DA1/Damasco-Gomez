using ParkingBusinessLogic;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFramework
{
    public class MyContext : DbContext
    {

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Purchase> Purchases { get; set; }



        public MyContext() : base("name=MyContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Account>().HasKey(a => a.Number);
            //modelBuilder.Entity<Purchase>().
            modelBuilder.Entity<Purchase>().HasKey(p => new { p.MyLicensePlate, p.MyInitHour, p.MyDay });
        }
       }
}
