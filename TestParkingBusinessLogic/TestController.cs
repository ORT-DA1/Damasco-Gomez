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
    public class TestController
    {
        [TestMethod]
        public void TestCreateAccout()
        {
            String num = "099 45 56 97";
            int balance = 190;
            Controller myC = new Controller();
            bool output = myC.RegisterAccount(num,balance);
            Assert.IsTrue(output);
        }

        [TestMethod]
        public void TestCreateAccount2()
        {
            String num = "099455697";
            int balance = 190;
            Controller myC = new Controller();
            bool output = myC.RegisterAccount(num, balance);
            
        }


        [TestMethod]
        public void TestRegisterAccountOk()
        {
            Controller myController = new Controller();
            myController.InitLists();
            myController.RegisterAccount("098567890", 500);
            Account output = myController.Accounts.ElementAt(0);
            Account expected = new Account("098567890", 500);
            Assert.AreEqual(output, expected);
        }
        [TestMethod]
        public void FindAccountOk()
        {
            Controller myController = new Controller();
            myController.InitLists();
            myController.RegisterAccount("098567890", 500);
            Account wanted = new Account("098567890", 500);
            Account expected = myController.FindAccount("098567890");
            Assert.AreEqual(wanted, expected);

        }
    }



    
}
