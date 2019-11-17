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
    public class TestControllerAccount
    {
        private ControllerAccount myController;
        [TestInitialize]
        public void Init()
        {
            myController = new ControllerAccount();
        }
        [TestMethod]
        public void TestRegisterAccountUru()
        {
            Account myAccount = new AccountUruguay();
            bool expected = myController.RegisterAccount(myAccount);
            Assert.IsTrue(expected);

        }
        [TestMethod]
        public void TestRegisterAccountArg()
        {
            Account myAccount = new AccountArgentina();
            bool expected = myController.RegisterAccount(myAccount);
            Assert.IsTrue(expected);

        }
        [TestMethod]
        public void TestisAccountUruEmpty()
        {
            Account myAccount = new AccountUruguay();
            //myController.RegisterAccount(myAccount);
            bool expected = myController.IsAccountEmpty(myAccount);
            Assert.IsTrue(expected);

        }
        [TestMethod]
        public void TestisAccountArgEmpty()
        {
            Account myAccount = new AccountArgentina();
            //myController.RegisterAccount(myAccount);
            bool expected = myController.IsAccountEmpty(myAccount);
            Assert.IsTrue(expected);

        }
        [TestMethod]
        public void TestFindAccountUruOk()
        {/*
            Account wanted = new AccountUruguay("098 567 890", "110");
            //myController.RegisterAccount(wanted);
            Account expected = myController.FindAccount("098 567 890");
            Assert.AreEqual(wanted.Number, expected.Number);
            */
        }
    }
}
