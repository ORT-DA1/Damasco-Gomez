using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using ParkingBusinessLogic;
using System.Collections.Generic;
using System.Linq;
using ParkingBusinessLogic.Exceptions;

namespace TestParkingBusinessLogic
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class TestController
    {
        private Controller myController;
        private Account account1;
        private string txt = "ABC 1290 120 15:00";

        [TestInitialize]
        public void InitTest()
        {
            myController = new Controller();
            account1 = new Account("099 111 111",1000);
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
        [ExpectedException(typeof(NotAccountException))]
        
        public void TestBuyParkingEmptyAccount()
        {
            string msg = "SBN 2208 150 10:00";
            myController.BuyParking("099856789", msg);
        }
        [TestMethod]
        public void TestCheckPurchaseDoesntHave()
        {
            string licensePlate = "NBA 5678";
            string dateTime = "7/5 12:00";
            bool dosentHave = myController.ChekPurchase(licensePlate, dateTime);
            Assert.IsFalse(dosentHave);
        }
        [TestMethod]
        public void TestCheckPurchaseOk()
        {
            string licensePlate = "ABC1290";
            string dateTime = "9/10 15:00";
            Purchase newPurchase =new  Purchase(txt,account1);
            myController.Purchases.Add(newPurchase);
            bool have = myController.ChekPurchase(licensePlate, dateTime);
            Console.WriteLine();
            Console.WriteLine(newPurchase.MyLicensePlate);
            Console.WriteLine(newPurchase.MyDay);
            Console.WriteLine(newPurchase.MyInitHour);
            Console.WriteLine(dateTime);
            Assert.IsTrue(have);
        }
        [TestMethod]
        public void TestFindPurchaseOk()
        {
            string licensePlate = "ABC1290";
            string date = DateTime.Now.ToString("dd-MM");
            string time = "15:00";
            Purchase newPurchase = new Purchase(txt,account1);
            myController.Purchases.Add(newPurchase);
            bool find = myController.FindPurchase(licensePlate,date,time);
            Assert.IsTrue(find);
        }
        [TestMethod]
        public void TestNotFindPurchase()
        {
            string licensePlate = "ABC 1290";
            string date = DateTime.Now.ToString("dd-MM");
            string time = "12:00";
            Purchase newPurchase = new Purchase(txt,account1);
            bool find = myController.FindPurchase(licensePlate, date,time);
            Assert.IsFalse(find);
        }
        [TestMethod]
        public void TestNotFindPurchase2()
        {
            string licensePlate = "AAA 1110";
            string date = "7/5";
            string time = "12:00";
            Purchase newPurchase = new Purchase(txt, account1);
            myController.Purchases.Add(newPurchase);
            bool find = myController.FindPurchase(licensePlate,date,time);
            Assert.IsFalse(find);
        }
        [TestMethod]
        public void TestNotFindPurchase3()
        {
            string licensePlate = "ABC 1290";
            string date = "7/5";
            string time = "15:00";
            Purchase newPurchase = new Purchase(txt, account1);
            myController.Purchases.Add(newPurchase);
            bool find = myController.FindPurchase(licensePlate, date, time);
            Assert.IsFalse(find);
        }
        [TestMethod]
        public void TestFindAddBalanceInAccount()
        {
            Account account = new Account();
            myController.AddBalanceInAccount(account, 800);
            int balance = account.Balance;
            Assert.AreEqual(balance,800);



        }
        




    }




}
