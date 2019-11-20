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
        string msg = "SBN1234 120 13:00";
        string msg2 = "SBN2345 13:00 120";

        [TestInitialize]
        public void InitTest()
        {
            MyContext myContext = new MyContext();
            myInsertPurchase = new DataAccessPurchase(myContext);
            myInsertAccount = new DataAccessAccount(myContext);
            myFindAccount = new DataFindAccount(myContext);
            AccountUruguay myAccountUru2 = new AccountUruguay("098872898", "100");
            AccountArgentina myAccountArg2 = new AccountArgentina("234-456-78", "100");
            myPurchaseUru = new PurchaseUruguay(msg, myAccountUru2);
            myPurchaseArg = new PurchaseArgentina(msg2, myAccountArg2);
            myInsertPurchase.DeleteDataBase();
        }
        [TestMethod]
        public void InsertPurchaseUru()
        {
            myInsertPurchase.Insert(myPurchaseUru);
        }
        [TestMethod]
        [ExpectedException(typeof(DbUpdateException))]
        public void InsertPurchaseUruFailSameInitHourAndLicense()
        {
            myInsertPurchase.Insert(myPurchaseUru);
            myInsertPurchase.Insert(myPurchaseUru);
        }
        [Ignore]
        [TestMethod]
        [ExpectedException(typeof(DbException))]
        public void InsertPurchaseUruFailConnection()
        {
            myInsertPurchase.Insert(myPurchaseUru);
        }
        [TestMethod]
        public void InsertPurchaseArg()
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
