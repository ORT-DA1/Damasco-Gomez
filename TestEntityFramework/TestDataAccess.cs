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
            Account myAccount = new AccountUruguay("098872898", "100");
            myDA.InsertAccount(myAccount);
        }
    }
}
