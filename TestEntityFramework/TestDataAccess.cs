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
        DataAccess myDA;
        AccountUruguay myAccountUru;
        AccountArgentina myAccountArg;
        PurchaseUruguay myPurchaseUru;
        PurchaseArgentina myPurchaseArg;
        string msg = "SBN1234 120 13:00";
        string msg2 = "SBN2345 13:00 120";

        [TestInitialize]
        public void InitTest()
        {
            myDA = new DataAccess();


            myAccountUru = new AccountUruguay("094485968", "100");
            AccountUruguay myAccountUru2 = new AccountUruguay("098872898", "100");

            myAccountArg = new AccountArgentina("123-456-78", "100");
            AccountArgentina myAccountArg2 = new AccountArgentina("234-456-78", "100");

            myPurchaseUru = new PurchaseUruguay(msg, myAccountUru2);    
            
            myPurchaseArg = new PurchaseArgentina(msg2, myAccountArg2);

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
        public void InsertPurchaseUru()
        {
            myDA.InsertPurchase(myPurchaseUru);
        }
        [TestMethod]
        public void InsertPurchaseArg()
        {
            myDA.InsertPurchase(myPurchaseArg);
        }
        [TestMethod]
        public void TestFindAcccountUruByNum()
        {
            Account accountUruguay = myDA.FindAccountByNum("094 485 968");
            Assert.AreEqual(myAccountUru.Number, accountUruguay.Number);
        }
        [TestMethod]
        public void TestFindAcccountArgByNum()
        {
            Account accountArgentina = myDA.FindAccountByNum("12345678");
            Assert.AreEqual(myAccountArg.Number, accountArgentina.Number);
        }

        [TestMethod]
        public void TestFindPurchaseUruByLicenseAndTime()
        {
            string license = "SBN1234";
            List<Purchase> purchaseUruguay = myDA.FindPurchaseByLicense(license);
            Assert.IsTrue(myPurchaseUru.ContainsLicense(purchaseUruguay,license));
        }
        [TestMethod]
        public void TestFindPurchaseArgByLicenseAndTime()
        {
            string license = "SBN1234";
            List<Purchase> purchaseArgentina = myDA.FindPurchaseByLicense(license);
            Assert.IsTrue(myPurchaseArg.ContainsLicense(purchaseArgentina, license));
        }


        [TestCleanup]
        public void FinishTest()
        {/*
            myDA.Context.Database.ExecuteSqlCommand("DELETE FROM Accounts;");
            myDA.Context.Database.ExecuteSqlCommand("DELETE FROM Purchases;");
            */
            myDA.DisposeMyContext();
        }

    }
}
