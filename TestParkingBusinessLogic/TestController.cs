using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using ParkingBusinessLogic;
using System.Collections.Generic;
using System.Linq;

namespace TestParkingBusinessLogic
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class TestController
    {
        private Controller myController;

        [TestInitialize]
        public void InitTest()
        {
            myController = new Controller();
        }

        [TestMethod]
        public void TestRegisterAccountOk()
        {
            Account expected = new Account("098567890", 500);
            myController.RegisterAccount(expected);
            Account output = myController.Accounts.ElementAt(0);
            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestFindAccountOk()
        {
            Account wanted = new Account("098567890", 500);
            myController.RegisterAccount(wanted);
            Account expected = myController.FindAccount("098 567 890");
            Assert.AreEqual(wanted, expected);

        }
        [TestMethod]
        public void TestisAccountEmpty()
        {
            Account myAccount = new Account();
            myController.RegisterAccount(myAccount);
            bool expected = myController.isAccountEmpty(myAccount);
            Assert.IsTrue(expected);

        }


        [TestMethod]
        public void TestChangeValueOfMinute()
        {
            int value = 22;
            myController.ChageValueMinute(value);
            int output = myController.ValueOfMinute.ValuePerMinutes;
            Assert.AreEqual(value, output);
        }


        [TestMethod]
        public void TestBuyParking()
        {
            Assert.IsTrue(true);
        }



    }




}
