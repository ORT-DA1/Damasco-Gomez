using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;
using ParkingBusinessLogic.Exceptions;

namespace TestParkingBusinessLogic
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class TestPurchase
    {

        [TestMethod]
        public void TestCreatePurchase()
        {
            Account myAccount = new Account("098872898");
            string text = "SBN 2208 150 10:00";
            Purchase myPurchase = new Purchase(text, myAccount);

        }

        [TestMethod]
        [Ignore]
        public void TestCreatePurchaseWithoutTime()
        {
            Account myAccount = new Account("098872898");
            string text = "SBN 2208 150";
            Purchase myPurchase = new Purchase(text, myAccount);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestCreatePurchaseWrongTxt()
        {
            Account myAccount = new Account("098872898");
            string text = "not there";
            Purchase myPurchase = new Purchase(text, myAccount);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidStartTimeException))]
        public void TestCreatePurchaseWithWrongTime()
        {
            Account myAccount = new Account("098872898");
            string text = "SBN 2208 150 19:00";
            Purchase myPurchase = new Purchase(text, myAccount);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestCreatePurchaseWithWrongLincense1()
        {
            Account myAccount = new Account("098872898");
            string text = "SBN P208 150 15:00";
            Purchase myPurchase = new Purchase(text, myAccount);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestCreatePurchaseWithWrongLincense2()
        {
            Account myAccount = new Account("098872898");
            string text = "SBN208 150 13:00";
            Purchase myPurchase = new Purchase(text, myAccount);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestCreatePurchaseWithWrongMinutes()
        {
            Account myAccount = new Account("098872898");
            string text = "SBN208 170 13:00";
            Purchase myPurchase = new Purchase(text, myAccount);
        }

        [TestMethod]
        public void TestCheckLicensePlate()
        {
            Account myAccount = new Account("098872898");
            string text = "SBN 2208 150 10:00";
            Purchase myPurchase = new Purchase(text, myAccount);
            string expected = "SBN2208";
            string output = myPurchase.MyLicensePlate;
            Assert.AreEqual(output, expected);

        }
        [TestMethod]
        public void TestCheckStartTime()
        {
            Account myAccount = new Account("098872898");
            string text = "SBN 2208 150 10:00";
            Purchase myPurchase = new Purchase(text, myAccount);
            string expected = "10:00";
            string output = myPurchase.MyInitHour;
            Assert.AreEqual(output, expected);

        }
        [TestMethod]
        public void TestCheckFinTime()
        {
            Account myAccount = new Account("098872898");
            string text = "SBN 2208 150 10:00";
            Purchase myPurchase = new Purchase(text, myAccount);
            string expected = "12:30";
            string output = myPurchase.MyFinHour;
            Assert.AreEqual(output, expected);

        }
        [TestMethod]
        public void TestCheckDay()
        {
            Account myAccount = new Account("098872898");
            string text = "SBN 2208 150 10:00";
            Purchase myPurchase = new Purchase(text, myAccount);
            string expected = "28-09";
            string output = myPurchase.MyDay;
            Assert.AreEqual(output, expected);

        }





    }
}
