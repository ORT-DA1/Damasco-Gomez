using EFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;
using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEntityFramework
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class TestDataFindPurchase
    {
        DataAccessPurchase myDAInsert;
        DataFindPurchase myDAFind;
        PurchaseUruguay myPurchaseUru;
        PurchaseArgentina myPurchaseArg;
        string msgUru = "SBN1234 120 13:00";
        string msgArg = "SBN2345 13:00 120";
        AccountUruguay myAccountUru2;
        AccountArgentina myAccountArg2;

        [TestInitialize]
        public void InitTest()
        {
            MyContext myContext = new MyContext();
            myDAInsert = new DataAccessPurchase(myContext);
            myDAFind = new DataFindPurchase(myContext);
            myAccountUru2 = new AccountUruguay("098872898", "100");
            myAccountArg2 = new AccountArgentina("234-456-78", "100");
            myPurchaseUru = new PurchaseUruguay(msgUru, myAccountUru2);
            myPurchaseArg = new PurchaseArgentina(msgArg, myAccountArg2);
            

            myDAInsert.DeleteDataBase();
        }

        [TestMethod]
        public void TestInsertUru()
        {
            myDAInsert.Insert(myPurchaseUru);
        }
        [TestMethod]
        public void TestInsertArg()
        {
            myDAInsert.Insert(myPurchaseArg);
        }

        [TestMethod]
        [ExpectedException(typeof(NotPurchaseWithLicense))]
        public void TestFindPurchaseUruByLicenseFail()
        {
            string license = "SBT1239";
            List<Purchase> purchaseUruguay = myDAFind.FindPurchaseByLicense(license);
        }
        
        [TestMethod]
        [ExpectedException(typeof(NotPurchaseWithLicense))]
        public void TestFindPurchaseArgByLicenseFail()
        {
            string license = "SBN2349";
            List<Purchase> purchaseArgentina = myDAFind.FindPurchaseByLicense(license);
        }

        [TestMethod]
        public void TestFindByLicense()
        {
            msgUru = "SBN4567 120 13:00";
            msgArg = "SBN4567 13:00 120";
            myPurchaseUru = new PurchaseUruguay(msgUru, myAccountUru2);
            myPurchaseArg = new PurchaseArgentina(msgArg, myAccountArg2);


            string license = "SBN4567";
            int expected = 2;
            List<Purchase> purchaseWithLicense = myDAFind.FindPurchaseByLicense(license);
            Assert.AreEqual(expected, purchaseWithLicense.Count());
        }
       
        [TestCleanup]
        public void FinishTest()
        {
            myDAFind.DisposeMyContext();
        }
    }
}
