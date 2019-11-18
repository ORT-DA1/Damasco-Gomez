using System;
using System.Collections.Generic;
using EFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;

namespace TestEntityFramework
{
    [TestClass]
    public class TestDataAccessAccount
    {
        DataAccessAccount myDA;
        AccountUruguay myAccountUru;
        AccountArgentina myAccountArg;
        PurchaseUruguay myPurchaseUru;
        PurchaseArgentina myPurchaseArg;
        string msg = "SBN1234 120 13:00";
        string msg2 = "SBN2345 13:00 120";

        [TestInitialize]
        public void InitTest()
        {
            myDA = new DataAccessAccount();

            myAccountUru = new AccountUruguay("094485968", "100");

            myAccountArg = new AccountArgentina("123-456-78", "100");

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
            Account accountUruguay = myDA.FindAccountByNumber("094 485 968");
            Assert.AreEqual(myAccountUru.Number, accountUruguay.Number);
        }
        [TestMethod]
        public void TestFindAcccountArgByNum()
        {
            Account accountArgentina = myDA.FindAccountByNumber("12345678");
            Assert.AreEqual(myAccountArg.Number, accountArgentina.Number);
        }



    }
}
