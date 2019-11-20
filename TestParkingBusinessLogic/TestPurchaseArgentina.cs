using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;
using ParkingBusinessLogic.Exceptions;
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
    public class TestPurchaseArgentina
    {
        private PurchaseArgentina myPurchase;
        private AccountArgentina emptyAccount;
        private string text = "SBN 2208 10:00 150";
        [TestInitialize]
        public void InitTest()
        {
            emptyAccount = new AccountArgentina();

            myPurchase = new PurchaseArgentina(text, emptyAccount);
        }

        [TestMethod]
        public void TestCreatePurchaseArg()
        {
            string text = "SBN 2208  10:00 150";
            myPurchase = new PurchaseArgentina(text, emptyAccount);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestCreatePurchaseArgNotValid()
        {
            string text = "SBN 2208 150 10:00 ";
            myPurchase = new PurchaseArgentina(text, emptyAccount);

        }
        [TestMethod]
        public void TestCreatePurchase2()
        {
            myPurchase = new PurchaseArgentina();

        }

        [TestMethod]
        [Ignore]
        public void TestCreatePurchaseWithoutTime()
        {
            string text = "SBN 2208 150";
            myPurchase = new PurchaseArgentina(text, emptyAccount);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestCreatePurchaseWrongTxt()
        {
            string text = "not there";
            myPurchase = new PurchaseArgentina(text, emptyAccount);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestCreatePurchaseWithWrongTime()
        {
            string text = "SBN 2208  19:00 150";
            myPurchase = new PurchaseArgentina(text, emptyAccount);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestCreatePurchaseWithWrongLincense1()
        {
            string text = "SBN P208  15:00 150";
            PurchaseArgentina myPurchase = new PurchaseArgentina(text, emptyAccount);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestCreatePurchaseWithWrongLincense2()
        {
            string text = "SBN208  13:00 150";
            PurchaseArgentina myPurchase = new PurchaseArgentina(text, emptyAccount);
        }
       

        [TestMethod]
        public void TestCheckLicensePlate()
        {
            string text = "SBN 2208 10:00 35";
            myPurchase = new PurchaseArgentina(text, emptyAccount);
            string expected = "SBN2208";
            string output = myPurchase.MyLicensePlate;
            Assert.AreEqual(output, expected);

        }
        [TestMethod]
        public void TestCheckStartTime()
        {
            string text = "SBN 2208  10:00 1570";
            myPurchase = new PurchaseArgentina(text, emptyAccount);
            string expected = "10:00";
            string output = myPurchase.MyInitHour;
            Assert.AreEqual(output, expected);

        }
        [TestMethod]
        public void TestCheckFinTime()
        {
            string text = "SBN 2208  10:30 150";
            PurchaseArgentina myPurchase = new PurchaseArgentina(text, emptyAccount);
            string expected = "13:00";
            string output = myPurchase.MyFinHour;
            Assert.AreEqual(expected, output);

        }
        [TestMethod]
        public void TestCheckFinTimeMore18()
        {
            string text = "SBN 2208  17:00 150";
            PurchaseArgentina myPurchase = new PurchaseArgentina(text, emptyAccount);
            string expected = "18:00";
            string output = myPurchase.MyFinHour;
            Assert.AreEqual(output, expected);

        }
        [TestMethod]
        public void TestAddMinHour()
        {
            int cantMinutes = 145;
            string startTime = "13:00";
            string output = myPurchase.AddMinHour(cantMinutes, startTime);
            string expected = "15:25";
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void TestCheckDay()
        {
            string text = "SBN 2208  10:00 115";
            PurchaseArgentina myPurchase = new PurchaseArgentina(text, emptyAccount);
            string expected = DateTime.Now.ToString("dd-MM");
            string output = myPurchase.MyDay;
            Assert.AreEqual(output, expected);

        }

    }
}
