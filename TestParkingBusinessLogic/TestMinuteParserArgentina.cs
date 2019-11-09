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
    public class TestMinuteParserArgentina
    {
        private MinuteParserArgentina myMinParArg;
        [TestInitialize]
        public void Init()
        {
            myMinParArg = new MinuteParserArgentina();
        }

        [TestMethod]
        public void TestGetCantMinutesCorrectArg()
        {
            string msg = ("ABC 1234 10:00 35");
            int output = myMinParArg.GetCantMinutes(msg);
            int expected = 35;
            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestErrorGetMinutesArg()
        {
            string msg = ("wrong text");
            int output = myMinParArg.GetCantMinutes(msg);
        }
      


        [TestMethod]
        public void TestParseTxtArg()
        {
            string msg = ("ABC 1234 10:00 45");
            string output = myMinParArg.ParseCantMinutes(msg);
            string expected = "45";
            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestParseTxt2Arg()
        {
            string msg = ("ABC 1234 45");
            string output = myMinParArg.ParseCantMinutes(msg);
            string expected = "45";
            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestParseTxtErrorArg()
        {
            string msg = ("ABC rwt");
            int output = myMinParArg.GetCantMinutes(msg);
        }

       
     

    }
}
