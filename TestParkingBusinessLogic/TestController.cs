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
            Account account1 = new Account("099 111 111",1000);
            myController.Accounts.Add(account1);
        }

        [TestMethod]
        public void TestRegisterAccountOk()
        {
            Account expected = new Account("098567890", 500);
            myController.RegisterAccount(expected);
            Account output = myController.Accounts.ElementAt(1);
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

        public void TestFindPurchaseOk()
        {
            Account myA = new Account("098437217",4799);
            Purchase wantedPurchase = new Purchase("SBN 1234 150 10:00", myA);
            myController.Purchases.Add(wantedPurchase);
            Purchase expected = myController.FindPurchase(myA);
            Assert.AreEqual(wantedPurchase, expected);

        }
        

        [TestMethod]
        public void TestBuyParking()
        {

            String num = "098437217";
            String msg = "SBN 2208 150 10:00";
            Account myAccount = new Account(num,4799);
            myController.RegisterAccount(myAccount);
            myController.BuyParking(num, msg);
            Purchase purchaseExpected = myController.FindPurchase(myAccount);
            Account myA = new Account(num, 299);
            Purchase purchase = new Purchase("SBN 2208 150 10:00", myA);
            Assert.AreEqual(purchaseExpected.MyAccount.Balance, purchase.MyAccount.Balance);
            


        }
        [TestMethod]
        public void TestCheckPurchase()
        {

            Assert.IsTrue(true);
        }



    }




}
