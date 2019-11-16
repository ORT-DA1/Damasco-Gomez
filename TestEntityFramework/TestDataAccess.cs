using System;
using EFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;

namespace TestEntityFramework
{
    [TestClass]
    public class TestDataAccess
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataAccess myDA = new DataAccess();
            Guid id = Guid.NewGuid();
            Account myAccount = new AccountUruguay(id,"098872898","100");
            myDA.InsertAccount(myAccount);
            Account accountUruguay = myDA.FindByNum("098 872 898");
            Assert.AreEqual(myAccount.Number, accountUruguay.Number);
            myDA.DisposeMyContext();
            
        }
    }
}
