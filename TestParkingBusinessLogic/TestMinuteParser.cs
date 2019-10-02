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
    public class TestMinuteParser
    {
        private MinuteParser myMinPar;
        [TestInitialize]
        public void Init()
        {
            myMinPar = new MinuteParser();
        }

        [TestMethod]
        public void TestBreakdownCantMinutesCorrect()
        {
            string msg = ("ABC 1234 60 10:00");
            int output = myMinPar.GetCantMinutes(msg);
            int expected = 60;
            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestErrorGetMinutes()
        {
            string msg = ("wrong text");
            int output = myMinPar.GetCantMinutes(msg);
        }

        [TestMethod]
        public void TestValidateMinute()
        {
            int min = 60 ;
            bool output = myMinPar.ValidateMinutesMultiple30(min);
            Assert.IsTrue(output);
        }
        [TestMethod]
        public void TestValidateMinuteWrong()
        {
            int min = 11;
            bool output = myMinPar.ValidateMinutesMultiple30(min);
            Assert.IsFalse(output);
        }

        [TestMethod]
        public void TestParseTxt()
        {
            string msg = ("ABC 1234 60 10:00");
            int output = myMinPar.ParseCantMinutes(msg);
            int expected = 60;
            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestParseTxt2()
        {
            string msg = ("ABC 1234 60");
            int output = myMinPar.ParseCantMinutes(msg);
            int expected = 60;
            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestParseTxtError()
        {
            string msg = ("ABC rwt");
            int output = myMinPar.GetCantMinutes(msg);
            int expected = 60;
            Assert.AreEqual(output, expected);
        }
    }
}
