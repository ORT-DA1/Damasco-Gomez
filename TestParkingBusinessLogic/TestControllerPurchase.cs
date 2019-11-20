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
        private string numArg = "123-45-678";
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
            myController.RegisterPurchaseUru(txtUru, numUru);
        }
        [TestMethod]
        public void TestRegisterPurchaseArg()
        {            
            myController.RegisterPurchaseArg(txtArg,numArg);
        }
        [TestMethod]
        [ExpectedException(typeof(ExceptionNumberIncorrectFormat))]
        public void TestRegisterPurchaseUruFailNum()
        {
            numUru = "9928731";
            myController.BuyParkingPurchaseUru(txtUru, numUru);
        }
        [TestMethod]
        [ExpectedException(typeof(ExceptionNumberIncorrectFormat))]
        public void TestRegisterPurchaseArgFailNum()
        {
            numArg = "09--8654--98";
            myController.BuyParkingPurchaseUru(txtArg, numArg);
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
            myController.ChangeValueMinuteUru(newValue.ToString());
            Assert.AreEqual(newValue, myController.valueOfMinuteUru.ValuePerMinutes);
        }
        [TestMethod]
        public void TestChangeValueMinuteArg()
        {
            int newValue = 15;
            myController.ChangeValueMinuteArg(newValue.ToString());
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
            accountUru = new AccountUruguay(numUru, "10");
            myController.dataAccessAccount.Insert(accountUru);
            myController.BuyParkingPurchaseUru(txtUru,accountUru.Number);
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
        [TestMethod]
        public void TestContainPurchaseInHour()
        {
            numUru = "099155499";
            accountUru = new AccountUruguay(numUru, "1000");
            myController.dataAccessAccount.Insert(accountUru);
            myController.BuyParkingPurchaseUru(txtUru, accountUru.Number);
            string license = "SBN1234";
            string dayToday = DateTime.Now.ToString("dd/MM");
            string txt = dayToday+" 15:00";
            bool output = myController.ContainPurchaseInHour(license, txt);
        }
        [TestMethod]
        public void TestContainPurchaseInHour2()
        {
            numUru = "099155499";
            accountUru = new AccountUruguay(numUru, "1000");
            myController.dataAccessAccount.Insert(accountUru);
            myController.BuyParkingPurchaseUru(txtUru, accountUru.Number);
            string license = "SBN1234";
            string dayToday = DateTime.Now.ToString("dd/MM");
            string txt = dayToday + " 13:00";
            bool output = myController.ContainPurchaseInHour(license, txt);
            Assert.IsTrue(output);
        }
        [TestMethod]
        public void TestContainPurchaseInHour3()
        {
            numUru = "099155499";
            accountUru = new AccountUruguay(numUru, "1000");
            myController.dataAccessAccount.Insert(accountUru);
            myController.BuyParkingPurchaseUru(txtUru, accountUru.Number);
            string license = "SBN1234";
            string dayToday = DateTime.Now.ToString("dd/MM");
            string txt = dayToday + " 14:59";
            bool output = myController.ContainPurchaseInHour(license, txt);
            Assert.IsTrue(output);
        }
        [TestMethod]
        public void TestContainPurchaseInHourFail()
        {
            numUru = "099155499";
            accountUru = new AccountUruguay(numUru, "1000");
            myController.dataAccessAccount.Insert(accountUru);
            myController.BuyParkingPurchaseUru(txtUru, accountUru.Number);
            string license = "SBN1234";
            string dayToday = DateTime.Now.ToString("dd/MM");
            string txt = dayToday + " 17:40";
            bool output = myController.ContainPurchaseInHour(license, txt);
            Assert.IsFalse(output);
        }
        [TestMethod]
        public void TestContainPurchaseUru()
        {
            string license = "SBN1234";
            string initHour = "13:00";
            string finHour = "15:00";
            string day = DateTime.Now.ToString("dd-MM");
            myController.RegisterPurchaseUru(txtUru, numUru);
            int output = myController.ContainPurchase(license,initHour,finHour,day).Count();
            Assert.AreEqual(1,output);
        }
        [TestMethod]
        public void TestContainPurchaseArg()
        {
            string license = "SBN2345";
            string initHour = "14:00";
            string finHour = "16:00";
            string day = DateTime.Now.ToString("dd-MM");
            myController.RegisterPurchaseArg(txtArg, numArg);
            int output = myController.ContainPurchase(license, initHour, finHour, day).Count();
            Assert.AreEqual(1,output);
        }
        [TestMethod]
        public void TestContainPurchaseFailUru()
        {
            string license = "SBN1234";
            string initHour = "14:00";
            string finHour = "15:00";
            string day = DateTime.Now.ToString("dd-MM");
            myController.RegisterPurchaseUru(txtUru, numUru);
            int output = myController.ContainPurchase(license, initHour, finHour, day).Count();
            Assert.AreEqual(0,output);
        }
        [TestMethod]
        public void TestContainPurchaseFailUru2()
        {
            string license = "SBN1234";
            string initHour = "13:00";
            string finHour = "18:00";
            string day = DateTime.Now.ToString("dd-MM");
            myController.RegisterPurchaseUru(txtUru, numUru);
            int output = myController.ContainPurchase(license, initHour, finHour, day).Count();
            Assert.AreEqual(0,output);
        }
        [TestMethod]
        public void TestContainPurchaseFailUru3()
        {
            string license = "SBN1234";
            string initHour = "13:00";
            string finHour = "15:00";
            string day = "11-10";
            myController.RegisterPurchaseUru(txtUru, numUru);
            int output = myController.ContainPurchase(license, initHour, finHour, day).Count();
            Assert.AreEqual(0,output);
        }
        [TestMethod]
        public void TestContainPurchaseFailArg()
        {
            string license = "SBN2345";
            string initHour = "13:00";
            string finHour = "16:00";
            string day = DateTime.Now.ToString("dd-MM");
            myController.RegisterPurchaseArg(txtArg, numArg);
            int output = myController.ContainPurchase(license, initHour, finHour, day).Count();
            Assert.AreEqual(0,output);
        }
        [TestMethod]
        public void TestContainPurchaseFailArg2()
        {
            string license = "SBN2345";
            string initHour = "14:00";
            string finHour = "15:00";
            string day = DateTime.Now.ToString("dd-MM");
            myController.RegisterPurchaseArg(txtArg, numArg);
            int output = myController.ContainPurchase(license, initHour, finHour, day).Count();
            Assert.AreEqual(0,output);

        }
        [TestMethod]
        public void TestContainPurchaseFailArg3()
        {
            string license = "SBN2345";
            string initHour = "14:00";
            string finHour = "16:00";
            string day = "18-09";
            myController.RegisterPurchaseArg(txtArg, numArg);
            int output = myController.ContainPurchase(license, initHour, finHour, day).Count();
            Assert.AreEqual(0,output);

        }

        [TestCleanup]
        public void FinishTest()
        {
            myController.dataFindPurchase.DisposeMyContext();
        }
    }
}
