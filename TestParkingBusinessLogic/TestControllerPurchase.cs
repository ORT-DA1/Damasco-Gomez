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
        private string txtUru = "SBN1234 120 13:00";
        private string txtArg = "SBN2345 14:00 120";
        private string numUru = "098872898";
        private string numArg = "12345678";

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

            Account accountArg = new AccountArgentina(numArg, "150");
            myController.dataAccessAccount.Insert(accountArg);
            Account accountUru = new AccountUruguay(numUru, "100");
            myController.dataAccessAccount.Insert(accountUru);
        }

        [TestMethod]
        public void TestRegisterPurchaseUru()
        {
            myController.RegisterPurchaseUru(txtUru,numUru);
        }
        [TestMethod]
        public void TestRegisterPurchaseArg()
        {            
            myController.RegisterPurchaseArg(txtArg,numArg);
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
            myController.BuyParkingPurchaseUru(txtUru, numUru);
        }
        [TestMethod]
        public void TestBuyParkingPurchaseUruFail()
        {
            
        }
        [TestMethod]
        public void TestBuyParkingPurchaseArg()
        {
            myController.BuyParkingPurchaseArg(txtArg, numArg);
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
