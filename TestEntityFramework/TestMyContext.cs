using EFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEntityFramework
{
    public class TestMyContext
    {
        [TestMethod]
        public void TestCreationContext()
        {
            MyContext context = new MyContext();
            Guid id = Guid.NewGuid();
            Account toSave = new AccountUruguay(id, "098872898","100");
            context.Accounts.Add(toSave);
            context.SaveChanges();
            context.Dispose();
        }
    }
}
