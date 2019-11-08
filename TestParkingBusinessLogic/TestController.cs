using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;
using ParkingBusinessLogic.Exceptions;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace TestParkingBusinessLogic
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class TestController
    {
        private Controller myController;
        private AccountUruguay account1;
        private string txt = "ABC 1290 120 15:00";
        private string checkTxt = DateTime.Now.ToString("dd/MM") + " 16:00";

        [TestInitialize]
        public void InitTest()
        {
            myController = new Controller();
            account1 = new AccountUruguay("099 111 111", "1000");
            myController.RegisterAccount(account1);
        }

        [TestMethod]
        public void TestRegisterAccountOk()
        {
            Account expected = new AccountUruguay("098567890", "500");
            myController.RegisterAccount(expected);
            Account output = myController.Accounts.ElementAt(1);
            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestFindAccountOk()
        {
            AccountUruguay wanted = new AccountUruguay("098567890", "500");
            myController.RegisterAccount(wanted);
            Account expected = myController.FindAccount("098 567 890");
            Assert.AreEqual(wanted, expected);

        }
        [TestMethod]
        public void TestisAccountEmpty()
        {
            Account myAccount = new AccountUruguay();
            myController.RegisterAccount(myAccount);
            bool expected = myController.IsAccountEmpty(myAccount);
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
            myController.BuyParking(account1.Number, txt);

            PurchaseUruguay expected = new PurchaseUruguay(txt, account1);
            Console.WriteLine(expected + "the purchase");
            Console.WriteLine(myController + "the conroller");
            Assert.IsTrue(myController.Purchases.Contains(expected));

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
            PurchaseUruguay newPurchase = new PurchaseUruguay(txt, account1);
            myController.Purchases.Add(newPurchase);

            string licensePlate = "ABC1290";
            string date = DateTime.Now.ToString("dd/MM");
            string dateTime = date + " 15:00";
            Console.WriteLine(dateTime);
            bool have = myController.ChekPurchase(licensePlate, dateTime);
            Assert.IsTrue(have);
        }
        [TestMethod]
        public void TestFindPurchaseOk()
        {
            string licensePlate = "ABC1290";
            string date = DateTime.Now.ToString("dd-MM");

            string time = "16:00";

            PurchaseUruguay newPurchase = new PurchaseUruguay(txt, account1);
            myController.Purchases.Add(newPurchase);
            bool find = myController.FindPurchase(licensePlate, date, time);
            Assert.IsTrue(find);
        }
        [TestMethod]
        public void TestNotFindPurchase()
        {
            string licensePlate = "ABC 1290";
            string date = DateTime.Now.ToString("dd-MM");
            string time = "12:00";
            PurchaseUruguay newPurchase = new PurchaseUruguay(txt, account1);
            bool find = myController.FindPurchase(licensePlate, date, time);
            Assert.IsFalse(find);
        }
        [TestMethod]
        public void TestNotFindPurchase2()
        {
            string licensePlate = "AAA 1110";
            string date = "7/5";
            string time = "12:00";
            PurchaseUruguay newPurchase = new PurchaseUruguay(txt, account1);
            myController.Purchases.Add(newPurchase);
            bool find = myController.FindPurchase(licensePlate, date, time);
            Assert.IsFalse(find);
        }
        [TestMethod]
        public void TestNotFindPurchase3()
        {
            string licensePlate = "ABC 1290";
            string date = "7/5";
            string time = "15:00";
            PurchaseUruguay newPurchase = new PurchaseUruguay(txt, account1);
            myController.Purchases.Add(newPurchase);
            bool find = myController.FindPurchase(licensePlate, date, time);
            Assert.IsFalse(find);
        }
        [TestMethod]
        public void TestFindAddBalanceInAccount()
        {
            Account account = new AccountUruguay();
            myController.AddBalanceInAccount(account, 800);
            int balance = account.Balance;
            Assert.AreEqual(balance, 800);



        }





    }




}
