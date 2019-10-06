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

        public void TestFindPurchaseOk()
        {
            Controller myController = new Controller();
            myController.InitLists();
            Account myA = new Account("098437217",4799);
            Purchase wantedPurchase = new Purchase("SBN 2208 150 10:00", myA);
            myController.InitLists();
            //agregar wanredpurchase a la coleccion de purchase 
            Purchase expected = myController.FindPurchase("SBN 1234");
            Assert.AreEqual(wantedPurchase, expected);

        }
        

        [TestMethod]
        public void TestBuyParking()
        {
            Controller myController = new Controller();
            myController.InitLists();
            String num = "098437217";
            String msg = "SBN 2208 150 10:00";
            Account myAccount = new Account(num,4799);
            myController.Accounts.Add(myAccount);
            myController.BuyParking(num, msg);
            //FIND COMPRA CON ESA ACCOUNT Y SI EL SALDO DE ESA CUENTA  ES 299


        }
        


    }




}
