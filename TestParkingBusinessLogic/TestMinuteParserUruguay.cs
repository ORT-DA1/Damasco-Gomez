using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;
using ParkingBusinessLogic.Exceptions;
using System.Diagnostics.CodeAnalysis;

namespace TestParkingBusinessLogic
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class TestMinuteParserUruguay
    {
        private MinuteParserUruguay myMinParUru;
        [TestInitialize]
        public void Init()
        {
            myMinParUru = new MinuteParserUruguay();
        }

        [TestMethod]
        public void TestGetCantMinutesCorrectUru()
        {
            string msg = ("ABC 1234 60 10:00");
            int output = myMinParUru.GetCantMinutes(msg);
            int expected = 60;
            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestErrorGetMinutesUru()
        {
            string msg = ("wrong text");
            int output = myMinParUru.GetCantMinutes(msg);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestErrorGetMinutes2Uru()
        {
            string msg = ("ABC 1234 355 10:00");
            int output = myMinParUru.GetCantMinutes(msg);
        }

        [TestMethod]
        public void TestValidateMinuteUru()
        {
            int min = 60;
            bool output = myMinParUru.ValidateMinutesMultiple30(min);
            Assert.IsTrue(output);
        }
        [TestMethod]
        public void TestValidateMinuteWrongUru()
        {
            int min = 11;
            bool output = myMinParUru.ValidateMinutesMultiple30(min);
            Assert.IsFalse(output);
        }

        [TestMethod]
        public void TestParseTxtUru()
        {
            string msg = ("ABC 1234 60 10:00");
            string output = myMinParUru.ParseCantMinutes(msg);
            string expected = "60";
            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestParseTxt2Uru()
        {
            string msg = ("ABC 1234 60");
            string output = myMinParUru.ParseCantMinutes(msg);
            string expected = "60";
            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestParseTxtErrorUru()
        {
            string msg = ("ABC rwt");
            int output = myMinParUru.GetCantMinutes(msg);
        }

        [TestMethod]
        public void TestCalculateCantMinutesFromPurchaseUru()
        {
            string initHour = "14:00";
            string finishHour = "18:00";
            int output = myMinParUru.CalculateCantMinutesFromPurchase(initHour, finishHour);
            int expected = 240;
            Assert.AreEqual(expected, output);
        }


    }
}
