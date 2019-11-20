using EFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
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
        DataAccessPurchase myInsertPurchase;
        DataAccessAccount myInsertAccount;
        DataFindAccount myFindAccount;
        PurchaseUruguay myPurchaseUru;
        PurchaseArgentina myPurchaseArg;
        Account myAccountUru;
        Account myAccountArg;
        string msgUru = "SBN1234 120 13:00";
        string msgArg = "SBN2345 13:00 120";

        [TestInitialize]
        public void InitTest()
        {
            MyContext myContext = new MyContext();
            myInsertPurchase = new DataAccessPurchase(myContext);
            myInsertAccount = new DataAccessAccount(myContext);
            myFindAccount = new DataFindAccount(myContext);
            myAccountUru = new AccountUruguay("098872898", "100");
            myAccountArg = new AccountArgentina("234-456-78", "100");
            myPurchaseUru = new PurchaseUruguay(msgUru, myAccountUru);
            myPurchaseArg = new PurchaseArgentina(msgArg, myAccountArg);
            myInsertPurchase.DeleteDataBase();
        }
        [TestMethod]
        public void TestInsertPurchaseUru()
        {
            myInsertPurchase.Insert(myPurchaseUru);
        }
        [TestMethod]
        [ExpectedException(typeof(DbUpdateException))]
        public void TestInsertPurchaseUruFailSameInitHourAndLicense()
        {
            myInsertPurchase.Insert(myPurchaseUru);
            myInsertPurchase.Insert(myPurchaseUru);
        }
        [TestMethod]
        public void TestInsertPurchaseUruFailSameLicense()
        {
            myInsertPurchase.Insert(myPurchaseUru);
            string newTxt = "SBN1234 30 10:00";
            Purchase newPurchase = new PurchaseUruguay(newTxt,myAccountUru);
            myInsertPurchase.Insert(newPurchase);
        }
        [Ignore]
        [TestMethod]
        [ExpectedException(typeof(DbException))]
        public void TestInsertPurchaseUruFailConnection()
        {
            myInsertPurchase.Insert(myPurchaseUru);
        }
        [TestMethod]
        public void TestInsertPurchaseArg()
        {
            myInsertPurchase.Insert(myPurchaseArg);
        }
        [TestMethod]
        [ExpectedException(typeof(DbUpdateException))]
        public void TestInsertPurchaseArgFailSameInitHourAndLicense()
        {
            myInsertPurchase.Insert(myPurchaseArg);
            myInsertPurchase.Insert(myPurchaseArg);
        }
        [TestMethod]
        public void TestInsertPurchaseArgFailSameLicense()
        {
            myInsertPurchase.Insert(myPurchaseArg);
            string newTxt = "SBN1234 10:00 23";
            Purchase newPurchase = new PurchaseArgentina(newTxt, myAccountArg);
            myInsertPurchase.Insert(newPurchase);
        }
        [Ignore]
        [TestMethod]
        [ExpectedException(typeof(DbException))]
        public void TestInsertPurchaseArgFailConnection()
        {
            myInsertPurchase.Insert(myPurchaseArg);
        }


        [TestCleanup]
        public void FinishTest()
        {
            myInsertPurchase.DisposeMyContext();
        }
    }
}
