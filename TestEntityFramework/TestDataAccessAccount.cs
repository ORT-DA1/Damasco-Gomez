using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;

namespace TestEntityFramework
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class TestDataAccessAccount
    {
        DataAccessAccount myDA;
        AccountUruguay myAccountUru;
        AccountArgentina myAccountArg;

        [TestInitialize]
        public void InitTest()
        {
            myDA = new DataAccessAccount();

            myAccountUru = new AccountUruguay("094485968", "100");

            myAccountArg = new AccountArgentina("123-456-78", "100");

            myDA.Context.Database.ExecuteSqlCommand("delete from Purchases;");
            myDA.Context.Database.ExecuteSqlCommand("delete from Accounts;");

        }

        [TestMethod]
        public void InsertAccountUru()
        {
            myDA.InsertAccount(myAccountUru);
        }
        [TestMethod]
        public void InsertAccountArg()
        {
            myDA.InsertAccount(myAccountArg);
        }

        [TestMethod]
        public void TestFindAcccountUruByNum()
        {
            myDA.InsertAccount(myAccountUru);
            Account accountUruguay = myDA.FindAccountByNumber("094 485 968");
            Assert.AreEqual(myAccountUru.Number, accountUruguay.Number);
        }
        [TestMethod]
        public void TestFindAcccountArgByNum()
        {
            myDA.InsertAccount(myAccountArg);
            Account accountArgentina = myDA.FindAccountByNumber("12345678");
            Assert.AreEqual(myAccountArg.Number, accountArgentina.Number);
        }
        [TestCleanup]
        public void FinishTest()
        {
            myDA.DisposeMyContext();
        }


    }
}
