using System;
using System.Collections.Generic;
using EFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;

namespace TestEntityFramework
{
    [TestClass]
    public class TestDataAccess
    {
        List<Guid> GuidList;
        DataAccess myDA;
        Account myAccount;

        [TestInitialize]
        public void InitTest()
        {
            GuidList = new List<Guid>();
            myDA = new DataAccess();
            
        }
        [TestCleanup]
        public void FinishTest()
        {
            foreach (Guid g in GuidList)
            {
                string sqlString = "delete from Accounts where Id = '" + g + "'";
                myDA.Context.Database.ExecuteSqlCommand(sqlString);
            }
            myDA.DisposeMyContext();
        }
        [TestMethod]
        public void InsertAccount()
        {
            Guid id = Guid.NewGuid();
            GuidList.Add(id);
            myAccount = new AccountUruguay(id, "091134827", "100");
            myDA.InsertAccount(myAccount);
        }
        [TestMethod]
        public void FindAcccountByNum()
        {
            Guid id = Guid.NewGuid();
            GuidList.Add(id);
            myAccount = new AccountUruguay(id, "098872898", "100");
            myDA.InsertAccount(myAccount);
            Account accountUruguay = myDA.FindByNum("098 872 898");
            Assert.AreEqual(myAccount.Number, accountUruguay.Number);
        }


    }
}
