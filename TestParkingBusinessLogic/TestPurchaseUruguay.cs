using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;
using ParkingBusinessLogic.Exceptions;
using System;
using System.Diagnostics.CodeAnalysis;

namespace TestParkingBusinessLogic
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class TestPurchaseUruguay
    {
        private PurchaseUruguay myPurchase;
        private AccountUruguay emptyAccount;
        private string text = "SBN 2208 150 10:00";
        [TestInitialize]
        public void InitTest()
        {
            emptyAccount = new AccountUruguay();

            myPurchase = new PurchaseUruguay(text, emptyAccount);
        }

        [TestMethod]
        public void TestCreatePurchase()
        {
            string text = "SBN 2208 150 10:00";
            myPurchase = new PurchaseUruguay(text, emptyAccount);

        }
        [TestMethod]
        public void TestCreatePurchase2()
        {
            myPurchase = new PurchaseUruguay();

        }
      
        [TestMethod]
        [Ignore]
        public void TestCreatePurchaseWithoutTime()
        {
            string text = "SBN 2208 150";
            myPurchase = new PurchaseUruguay(text, emptyAccount);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestCreatePurchaseWrongTxt()
        {
            string text = "not there";
            myPurchase = new PurchaseUruguay(text, emptyAccount);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestCreatePurchaseWithWrongTime()
        {
            string text = "SBN 2208 150 19:00";
            myPurchase = new PurchaseUruguay(text, emptyAccount);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestCreatePurchaseWithWrongLincense1()
        {
            string text = "SBN P208 150 15:00";
            PurchaseUruguay myPurchase = new PurchaseUruguay(text, emptyAccount);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestCreatePurchaseWithWrongLincense2()
        {
            string text = "SBN208 150 13:00";
            PurchaseUruguay myPurchase = new PurchaseUruguay(text, emptyAccount);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestCreatePurchaseWithWrongMinutes()
        {
            string text = "SBN208 170 13:00";
            PurchaseUruguay myPurchase = new PurchaseUruguay(text, emptyAccount);
        }

        [TestMethod]
        public void TestCheckLicensePlate()
        {
            string text = "SBN 2208 150 10:00";
            myPurchase = new PurchaseUruguay(text, emptyAccount);
            string expected = "SBN2208";
            string output = myPurchase.MyLicensePlate;
            Assert.AreEqual(output, expected);

        }
        [TestMethod]
        public void TestCheckStartTime()
        {
            string text = "SBN 2208 150 10:00";
            myPurchase = new PurchaseUruguay(text, emptyAccount);
            string expected = "10:00";
            string output = myPurchase.MyInitHour;
            Assert.AreEqual(output, expected);

        }
        [TestMethod]
        public void TestCheckFinTime()
        {
            string text = "SBN 2208 150 10:30";
            PurchaseUruguay myPurchase = new PurchaseUruguay(text, emptyAccount);
            string expected = "13:00";
            string output = myPurchase.MyFinHour;
            Assert.AreEqual(expected, output);

        }
        [TestMethod]
        public void TestCheckFinTimeMore18()
        {
            string text = "SBN 2208 150 17:00";
            PurchaseUruguay myPurchase = new PurchaseUruguay(text, emptyAccount);
            string expected = "18:00";
            string output = myPurchase.MyFinHour;
            Assert.AreEqual(output, expected);

        }
        [TestMethod]
        public void TestAddMinHour()
        {
            int cantMinutes = 150;
            string startTime = "13:00";
            string output = myPurchase.AddMinHour(cantMinutes, startTime);
            string expected = "15:30";
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void TestOutOf18HoursTrue()
        {
            DateTime dateTime = new DateTime();
            dateTime = dateTime.Date.AddHours(19).AddMinutes(58);
            string inputTime = dateTime.ToString("HH:mm");
            bool output = myPurchase.OutOf18Hours(inputTime);
            Assert.IsTrue(output);
        }
        [TestMethod]
        public void TestOutOf18HoursTrue2()
        {
            DateTime dateTime = new DateTime();
            dateTime = dateTime.Date.AddHours(18).AddMinutes(38);
            string inputTime = dateTime.ToString("HH:mm");
            bool output = myPurchase.OutOf18Hours(inputTime);
            Assert.IsTrue(output);
        }
        [TestMethod]
        public void TestOutOf18HoursFalse()
        {
            DateTime dateTime = new DateTime();
            dateTime = dateTime.Date.AddHours(14).AddMinutes(58);
            string inputTime = dateTime.ToString("hh:mm");
            bool output = myPurchase.OutOf18Hours(inputTime);
            Assert.IsFalse(output);
        }
        [TestMethod]
        public void TestOutOf18HoursFalse2()
        {
            DateTime dateTime = new DateTime();
            dateTime = dateTime.Date.AddHours(18).AddMinutes(0);
            string inputTime = dateTime.ToString("hh:mm");
            bool output = myPurchase.OutOf18Hours(inputTime);
            Assert.IsFalse(output);
        }
        [TestMethod]
        public void TestCheckDay()
        {
            string text = "SBN 2208 150 10:00";
            PurchaseUruguay myPurchase = new PurchaseUruguay(text, emptyAccount);
            string expected = DateTime.Now.ToString("dd-MM");
            string output = myPurchase.MyDay;
            Assert.AreEqual(output, expected);

        }

        
        
        [TestMethod]
        public void TestEqualsTrue()
        {
            string text = "SBN 2208 150 10:00";
            PurchaseUruguay otherPurchase = new PurchaseUruguay(text, emptyAccount);
            bool output = myPurchase.Equals(otherPurchase);
            Assert.IsTrue(output);
        }
        [TestMethod]
        public void TestEqualsFalse()
        {
            string text = "SBN 2208 120 10:00";
            PurchaseUruguay otherPurchase = new PurchaseUruguay(text, emptyAccount);
            bool output = myPurchase.Equals(otherPurchase);
            Assert.IsFalse(output);
        }
        [TestMethod]
        public void TestEqualsFalse2()
        {
            string text = "SBN 2208 150 12:00";
            PurchaseUruguay otherPurchase = new PurchaseUruguay(text, emptyAccount);
            bool output = myPurchase.Equals(otherPurchase);
            Assert.IsFalse(output);
        }
        [TestMethod]
        public void TestEqualsFalse3()
        {
            string text = "SBN 2508 150 10:00";
            PurchaseUruguay otherPurchase = new PurchaseUruguay(text, emptyAccount);
            bool output = myPurchase.Equals(otherPurchase);
            Assert.IsFalse(output);
        }


    }
}
