using EFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParkingBusinessLogic
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class TestControllerPurchase
    {
        private ControllerPurchase myController;
        private Purchase myPurchaseArg;
        private Purchase myPurchaseUru;
        private string txtUru = "SBN1234 120 13:00";
        private string txtArg = "SBN2345 14:00 120";
        private Account accountUru;
        private Account accountArg;

        [TestInitialize]
        public void Init()
        {
            MyContext myContext = new MyContext();
            DataAccessAccount accessAccount = new DataAccessAccount(myContext);
            DataFindAccount findAccount = new DataFindAccount(myContext);
            DataAccessPurchase accessPurchase = new DataAccessPurchase(myContext);
            DataFindPurchase findPurchase = new DataFindPurchase(myContext);
            myController = new ControllerPurchase(accessPurchase, accessAccount, findAccount, findPurchase);
            myController.dataAccessAccount.DeleteDataBase();
            accountUru = new AccountUruguay("098872898", "100");
            accountArg = new AccountArgentina("12345678", "100");
            myPurchaseArg = new PurchaseArgentina(txtArg,accountArg);
            myPurchaseUru = new PurchaseUruguay(txtUru, accountUru);
        }

        [TestMethod]
        public void TestRegisterPurchaseUru()
        {
            myController.RegisterPurchase(myPurchaseUru);
        }
        [TestMethod]
        public void TestRegisterPurchaseArg()
        {
            myController.RegisterPurchase(myPurchaseArg);
        }
        [TestMethod]
        public void TestRegisterPurchaseUruFail()
        {

        }
        [TestMethod]
        public void TestRegisterPurchaseArgFail()
        {

        }
        [TestMethod]
        public void TestChangeValueMinuteUru()
        {
            int newValue = 15;
            myController.ChangeValueMinuteUru(newValue);
            Assert.AreEqual(newValue, myController.valueOfMinuteUru.ValuePerMinutes);
        }
        [TestMethod]
        public void TestChangeValueMinuteArg()
        {
            int newValue = 15;
            myController.ChangeValueMinuteArg(newValue);
            Assert.AreEqual(newValue, myController.valueOfMinuteArg.ValuePerMinutes);

        }
        [TestMethod]
        public void TestBuyParkingPurchaseUru()
        {

        }
        [TestMethod]
        public void TestBuyParkingPurchaseUruFail()
        {

        }
        [TestMethod]
        public void TestBuyParkingPurchaseArg()
        {

        }
        [TestMethod]
        public void TestBuyParkingPurchaseArgFail()
        {

        }
        [TestMethod]
        public void TestFindAndDiscount()
        {

        }
        [TestMethod]
        public void TestFindAndDiscountFail()
        {

        }
        [TestMethod]
        public void TestFindAmountFromPurchase()
        {

        }
        [TestMethod]
        public void TestFindAmountFromPurchaseFail()
        {

        }
    }
}
