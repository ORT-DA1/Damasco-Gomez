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

namespace TestParkingBusinessLogic
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class TestControllerPurchase
    {
        private ControllerPurchase myController;
        private string txtUru = "SBN1234 120 13:00";
        private string txtArg = "SBN2345 14:00 120";
        private string numUru = "098 872 898";
        private string numArg = "12345678";
        Account accountArg;
        Account accountUru;

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

            accountArg = new AccountArgentina(numArg, "1500");
            myController.dataAccessAccount.Insert(accountArg);
            accountUru = new AccountUruguay(numUru, "1000");
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
        public void TestDiscountArg()
        {
            int expected = accountArg.Balance - 120*3;
            myController.BuyParkingPurchaseArg(txtArg, numArg);
            int output = accountArg.Balance;
            Assert.AreEqual(expected, output);
        }
        [TestMethod]
        public void TestDiscountUru()
        {
            int expected = accountUru.Balance - 120 * 3;
            myController.BuyParkingPurchaseUru(txtUru, numUru);
            int output = accountUru.Balance;
            Assert.AreEqual(expected, output);
        }
        [TestMethod]
        [ExpectedException(typeof(InsufficientBalanceException))]
        public void TestDiscountFailUru()
        {
            numUru = "099155499";
            accountUru = new AccountUruguay(numUru, "100");
            myController.dataAccessAccount.Insert(accountUru);
            myController.BuyParkingPurchaseUru(txtUru, numUru);
        }
        [TestMethod]
        [ExpectedException(typeof(InsufficientBalanceException))]
        public void TestDiscountFailArg()
        {
            numArg = "23456789";
            accountArg = new AccountArgentina(numArg, "100");
            myController.dataAccessAccount.Insert(accountArg);
            myController.BuyParkingPurchaseArg(txtArg, numArg);
        }
    }
}
