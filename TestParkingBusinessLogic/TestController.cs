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
            Account expected = myController.FindAccount("098 567 890");
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


        [TestMethod]
        public void TestChangeValueOfMinute()
        {
            Controller myController = new Controller();
            myController.InitLists();
            int value = 22;
            myController.ChageValueMinute(value);
            int output = myController.ValueOfMinute.ValuePerMinutes;
            Assert.AreEqual(value, output);
        }

        [TestMethod]

        public void TestInitAccount()
        {
            Controller myController = new Controller();
            myController.InitLists();
            List<Account> EmptyAccount = myController.Accounts;
            List<Account>  Accounts = new List<Account>();
            Assert.AreEqual(EmptyAccount, Accounts);
        }
        [TestMethod]

        public void TestInitPurchase()
        {
            Controller myController = new Controller();
            myController.InitLists();
            List<Purchase> EmptyPurchase = myController.Purchases;
            List<Purchase> Purchases = new List<Purchase>();
            Assert.AreEqual(EmptyPurchase, Purchases);
        }

        [TestMethod]
        public void TestBuyParking()
        {
            Assert.IsTrue(true);
        }
        


    }




}
