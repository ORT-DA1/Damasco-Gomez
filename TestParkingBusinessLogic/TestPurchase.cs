using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;
using ParkingBusinessLogic.Exceptions;
using System;
using System.Diagnostics.CodeAnalysis;

namespace TestParkingBusinessLogic
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class TestPurchase
    {
        private Purchase myPurchase;
        private Account emptyAccount;
        private string text = "SBN 2208 150 10:00";
        [TestInitialize]
        public void InitTest()
        {
            emptyAccount = new Account();

            myPurchase = new Purchase(text, emptyAccount);
        }

        [TestMethod]
        public void TestCreatePurchase()
        {
            string text = "SBN 2208 150 10:00";
            myPurchase = new Purchase(text, emptyAccount);

        }
        [TestMethod]
        public void TestCreatePurchase2()
        {
            myPurchase = new Purchase();

        }
        [TestMethod]
        public void TestGetAccount()
        {
            Account otherAccount = new Account();
            Purchase newPurchase = new Purchase(text, otherAccount);
            Account output = newPurchase.MyAccount;
            Assert.AreEqual(otherAccount, output);

        }
        [TestMethod]
        [Ignore]
        public void TestCreatePurchaseWithoutTime()
        {
            string text = "SBN 2208 150";
            myPurchase = new Purchase(text, emptyAccount);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestCreatePurchaseWrongTxt()
        {
            string text = "not there";
            myPurchase = new Purchase(text, emptyAccount);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestCreatePurchaseWithWrongTime()
        {
            string text = "SBN 2208 150 19:00";
            myPurchase = new Purchase(text, emptyAccount);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestCreatePurchaseWithWrongLincense1()
        {
            string text = "SBN P208 150 15:00";
            Purchase myPurchase = new Purchase(text, emptyAccount);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestCreatePurchaseWithWrongLincense2()
        {
            string text = "SBN208 150 13:00";
            Purchase myPurchase = new Purchase(text, emptyAccount);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestCreatePurchaseWithWrongMinutes()
        {
            string text = "SBN208 170 13:00";
            Purchase myPurchase = new Purchase(text, emptyAccount);
        }

        [TestMethod]
        public void TestCheckLicensePlate()
        {
            string text = "SBN 2208 150 10:00";
            myPurchase = new Purchase(text, emptyAccount);
            string expected = "SBN2208";
            string output = myPurchase.MyLicensePlate;
            Assert.AreEqual(output, expected);

        }
        [TestMethod]
        public void TestCheckStartTime()
        {
            string text = "SBN 2208 150 10:00";
            myPurchase = new Purchase(text, emptyAccount);
            string expected = "10:00";
            string output = myPurchase.MyInitHour;
            Assert.AreEqual(output, expected);

        }
        [TestMethod]
        public void TestCheckFinTime()
        {
            string text = "SBN 2208 150 10:30";
            Purchase myPurchase = new Purchase(text, emptyAccount);
            string expected = "13:00";
            string output = myPurchase.MyFinHour;
            Assert.AreEqual(expected, output);

        }
        [TestMethod]
        public void TestCheckFinTimeMore18()
        {
            string text = "SBN 2208 150 17:00";
            Purchase myPurchase = new Purchase(text, emptyAccount);
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
            Purchase myPurchase = new Purchase(text, emptyAccount);
            string expected = DateTime.Now.ToString("dd-MM");
            string output = myPurchase.MyDay;
            Assert.AreEqual(output, expected);

        }

        [TestMethod]
        public void TestCompareHoursTrue()
        {
            string initHour = "16:40";
            string finitHour = "18:00";
            string otherHour = "17:00";
            bool output = myPurchase.CompareHours(initHour, finitHour, otherHour);
            Assert.IsTrue(output);
        }
        [TestMethod]
        public void TestCompareHoursTrue2()
        {
            string initHour = "17:40";
            string finitHour = "18:00";
            string otherHour = "17:50";
            bool output = myPurchase.CompareHours(initHour, finitHour, otherHour);
            Assert.IsTrue(output);
        }
        [TestMethod]
        public void TestCompareHoursTrue3()
        {
            string initHour = "12:40";
            string finitHour = "17:39";
            string otherHour = "17:30";
            bool output = myPurchase.CompareHours(initHour, finitHour, otherHour);
            Assert.IsTrue(output);
        }
        [TestMethod]
        public void TestCompareHoursFalse()
        {
            string initHour = "14:10";
            string finitHour = "17:22";
            string otherHour = "11:00";
            bool output = myPurchase.CompareHours(initHour, finitHour,otherHour);
            Assert.IsFalse(output);
        }
        [TestMethod]
        public void TestCompareHoursFalse1()
        {
            string initHour = "14:10";
            string finitHour = "15:22";
            string otherHour = "17:00";
            bool output = myPurchase.CompareHours(initHour, finitHour, otherHour);
            Assert.IsFalse(output);
        }
        [TestMethod]
        public void TestCompareHoursFalse2()
        {
            string initHour = "11:30";
            string finitHour = "12:22";
            string otherHour = "11:00";
            bool output = myPurchase.CompareHours(initHour, finitHour,otherHour);
            Assert.IsFalse(output);
        }
        [TestMethod]
        public void TestCompareHoursFals3()
        {
            string initHour = "10:50";
            string finitHour = "11:11";
            string otherHour = "11:40";
            bool output = myPurchase.CompareHours(initHour, finitHour,otherHour);
            Assert.IsFalse(output);
        }
        [TestMethod]
        public void TestContainValuesTrue()
        {
            string licensePlate = "SBN2208";
            string date = DateTime.Now.ToString("dd-MM");
            string initTime = "12:00";
            bool output = myPurchase.ContainValues(licensePlate, date, initTime);
            Assert.IsTrue(output);
        }
        [TestMethod]
        public void TestContainValuesFalse()
        {
            string licensePlate = "SBN2208";
            string date = "11-11";
            string initTime = "12:00";
            bool output = myPurchase.ContainValues(licensePlate, date, initTime);
            Assert.IsFalse(output);
        }
        [TestMethod]
        public void TestContainValuesFalse2()
        {
            string licensePlate = "SBN2208";
            string date = DateTime.Now.ToString("dd-MM");
            string initTime = "15:00";
            bool output = myPurchase.ContainValues(licensePlate, date, initTime);
            Assert.IsFalse(output);
        }
        [TestMethod]
        public void TestEqualsTrue()
        {
            string text = "SBN 2208 150 10:00";
            Purchase otherPurchase = new Purchase(text, emptyAccount);
            bool output = myPurchase.Equals(otherPurchase);
            Assert.IsTrue(output);
        }
        [TestMethod]
        public void TestEqualsFalse()
        {
            string text = "SBN 2208 120 10:00";
            Purchase otherPurchase = new Purchase(text, emptyAccount);
            bool output = myPurchase.Equals(otherPurchase);
            Assert.IsFalse(output);
        }
        [TestMethod]
        public void TestEqualsFalse2()
        {
            string text = "SBN 2208 150 12:00";
            Purchase otherPurchase = new Purchase(text, emptyAccount);
            bool output = myPurchase.Equals(otherPurchase);
            Assert.IsFalse(output);
        }
        [TestMethod]
        public void TestEqualsFalse3()
        {
            string text = "SBN 2508 150 10:00";
            Purchase otherPurchase = new Purchase(text, emptyAccount);
            bool output = myPurchase.Equals(otherPurchase);
            Assert.IsFalse(output);
        }


    }
}
