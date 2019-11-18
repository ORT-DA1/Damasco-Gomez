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
    }
}
