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
        string msg = "SBN1234 120 13:00";
        string msg2 = "SBN2345 13:00 120";

        [TestInitialize]
        public void InitTest()
        {
            MyContext myContext = new MyContext();
            myDAInsert = new DataAccessPurchase(myContext);
            myDAFind = new DataFindPurchase(myContext);
            AccountUruguay myAccountUru2 = new AccountUruguay("098872898", "100");
            AccountArgentina myAccountArg2 = new AccountArgentina("234-456-78", "100");
            myPurchaseUru = new PurchaseUruguay(msg, myAccountUru2);
            myPurchaseArg = new PurchaseArgentina(msg2, myAccountArg2);
            myDAInsert.DeleteDataBase();
        }
        
        [TestMethod]
        [ExpectedException(typeof(NotPurchaseWithLicense))]
        public void TestFindPurchaseUruByLicenseFail()
        {
            string license = "SBT1234";
            List<Purchase> purchaseUruguay = myDAFind.FindPurchaseByLicense(license);
        }
        
        [TestMethod]
        [ExpectedException(typeof(NotPurchaseWithLicense))]
        public void TestFindPurchaseArgByLicenseFail()
        {
            string license = "SBN2349";
            List<Purchase> purchaseArgentina = myDAFind.FindPurchaseByLicense(license);
        }
        [TestCleanup]
        public void FinishTest()
        {
            myDAFind.DisposeMyContext();
        }
    }
}
