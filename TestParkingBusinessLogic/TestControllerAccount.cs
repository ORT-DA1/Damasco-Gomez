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
    public class TestControllerAccount
    {
        private ControllerAccount myController;

        [TestInitialize]
        public void Init()
        {
            MyContext myContext = new MyContext();
            myController = new ControllerAccount(new DataAccessAccount(myContext), new DataFindAccount(myContext));
            myController.dataAccessAccount.DeleteDataBase();
        }
        [TestMethod]
        public void TestRegisterAccountUru()
        {
            Account myAccount = new AccountUruguay("098123456","100");
            bool expected = myController.RegisterAccount(myAccount);

        }
        [TestMethod]
        public void TestRegisterAccountArg()
        {
            Account myAccount = new AccountArgentina("123456","100");
            bool expected = myController.RegisterAccount(myAccount);

        }
        [TestMethod]
        public void TestFindAccountUruOk()
        {
            Account wanted = new AccountUruguay("098 567 890", "110");
            myController.RegisterAccount(wanted);
            Account expected = myController.FindAccountByNum("098 567 890");
            Assert.AreEqual(wanted.Number, expected.Number);

        }
        [TestMethod]
        public void TestFindAccountArgOk()
        {
            Account wanted = new AccountArgentina("123-456-78", "110");
            myController.RegisterAccount(wanted);
            Account expected = myController.FindAccountByNum("12345678");
            Assert.AreEqual(wanted.Number, expected.Number);

        }
        [TestMethod]
        public void TestAddAmountBalanceUru()
        {
            string numUru = "098 34 56 76";
            int initBalance = 110;
            int addBalance = 220;
            int finalBalance = initBalance + addBalance;
            Account wanted = new AccountUruguay(numUru, initBalance.ToString());
            myController.RegisterAccount(wanted);
            myController.AddAmountBalanceUru(numUru, addBalance.ToString());
            Assert.AreEqual(finalBalance, wanted.Balance);

        }
        [TestMethod]
        [ExpectedException(typeof(NegativeNumberException))]
        public void TestAddAmountBalanceUruFail()
        {
            string numUru = "098 34 56 76";
            int initBalance = 110;
            int addBalance = -220;
            Account wanted = new AccountUruguay(numUru, initBalance.ToString());
            myController.RegisterAccount(wanted);
            myController.AddAmountBalanceArg(numUru, addBalance.ToString());
        }
        [TestMethod]
        public void TestAddAmountBalanceArg()
        {
            string numArg = "12345678";
            int initBalance = 110;
            int addBalance = 220;
            int finalBalance = initBalance + addBalance;
            Account wanted = new AccountArgentina(numArg, initBalance.ToString());
            myController.RegisterAccount(wanted);
            myController.AddAmountBalanceArg(numArg, addBalance.ToString());
            Assert.AreEqual(finalBalance, wanted.Balance);

        }
        [TestMethod]
        [ExpectedException(typeof(NegativeNumberException))]
        public void TestAddAmountBalanceArgFail()
        {
            string numArg = "123456-78";
            int initBalance = 110;
            int addBalance = -220;
            Account wanted = new AccountArgentina(numArg, initBalance.ToString());
            myController.RegisterAccount(wanted);
            myController.AddAmountBalanceUru(numArg, addBalance.ToString());
        }
        [TestCleanup]
        public void FinishTest()
        {
            myController.dataFindAccount.DisposeMyContext();
        }
    }
}
