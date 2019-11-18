using EFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEntityFramework
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class TestDataAccessPurchase
    {
        DataAccessPurchase myDA;
        PurchaseUruguay myPurchaseUru;
        PurchaseArgentina myPurchaseArg;
        string msg = "SBN1234 120 13:00";
        string msg2 = "SBN2345 13:00 120";

        [TestInitialize]
        public void InitTest()
        {
            myDA = new DataAccessPurchase(new MyContext());

            AccountUruguay myAccountUru2 = new AccountUruguay("098872898", "100");
            AccountArgentina myAccountArg2 = new AccountArgentina("234-456-78", "100");
            myPurchaseUru = new PurchaseUruguay(msg, myAccountUru2);
            myPurchaseArg = new PurchaseArgentina(msg2, myAccountArg2);


            myDA.Context.Database.ExecuteSqlCommand("delete from Purchases;");
            myDA.Context.Database.ExecuteSqlCommand("delete from Accounts;");

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
        public void TestFindPurchaseUruByLicenseAndTime()
        {
            myDA.InsertPurchase(myPurchaseUru);
            string license = "SBN1234";
            List<Purchase> purchaseUruguay = myDA.FindPurchaseByLicense(license);
            Assert.IsTrue(myPurchaseUru.ContainsLicense(purchaseUruguay, license));
        }
        [TestMethod]
        public void TestFindPurchaseArgByLicenseAndTime()
        {
            myDA.InsertPurchase(myPurchaseArg);
            string license = "SBN2345";
            List<Purchase> purchaseArgentina = myDA.FindPurchaseByLicense(license);
            Assert.IsTrue(myPurchaseArg.ContainsLicense(purchaseArgentina, license));
        }


        [TestCleanup]
        public void FinishTest()
        {
            myDA.DisposeMyContext();
        }
    }
}
