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
            Account expected = new Account(num, balance);
            Controller myC = new Controller();
            bool output = myC.RegisterAccount(expected);
            Assert.IsTrue(output);
        }

        [TestMethod]
        public void TestCreateAccount2()
        {
            String num = "099455697";
            int balance = 190;
            Account expected = new Account(num, balance);
            Controller myC = new Controller();
            bool output = myC.RegisterAccount(expected);
            
        }


        [TestMethod]
        public void TestRegisterAccountOk()
        {
            Controller myController = new Controller();
            myController.InitLists();
            Account expected = new Account("098567890", 500);
            myController.RegisterAccount(expected);
            Account output = myController.Accounts.ElementAt(0);
          
            Assert.AreEqual(output, expected);
        }
        [TestMethod]
        public void TestFindAccountOk()
        {
            Controller myController = new Controller();
            myController.InitLists();
            Account wanted = new Account("098567890", 500);
            myController.RegisterAccount(wanted);
            Account expected = myController.FindAccount("098567890");
            Assert.AreEqual(wanted, expected);

        }
        [TestMethod]
        public void TestisAccountEmpty()
        {
            Controller myController = new Controller();
            myController.InitLists();
            Account myAccount = new Account();
            myController.RegisterAccount(myAccount);
            bool  expected = myController.isAccountEmpty(myAccount);
            Assert.IsTrue(expected);

        }
        
    }



    
}
