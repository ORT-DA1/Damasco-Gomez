using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;
using ParkingBusinessLogic.Exceptions;
using System.Diagnostics.CodeAnalysis;

namespace TestParkingBusinessLogic
{
    [ExcludeFromCodeCoverage]
    [TestClass]

    public class TestLicensePlateParser

    {


        private LicensePlateParser licensePlateParser;
        [TestInitialize]
        public void InitTest()
        {
            licensePlateParser = new LicensePlateParser();
        }

        [TestMethod]
        public void TestValidateLicensePlateOk()
        {
            string input = "SBN2208";
            Assert.IsTrue(licensePlateParser.ValidateLicensePlate(input));
        }
        [TestMethod]
        public void TestValidateLicensePlateError1()
        {
            string input = "SBN208";
            Assert.IsFalse(licensePlateParser.ValidateLicensePlate(input));
        }


        [TestMethod]
        public void TestValidateLicensePlateError2()
        {
            string input = "";
            Assert.IsFalse(licensePlateParser.ValidateLicensePlate(input));
        }

        [TestMethod]
        public void TestParseLicensePlate()
        {
            string licensePlateParserResult = licensePlateParser.ParseLicensePlate("SBN2208 120 10:00");
            string expected = "SBN2208";
            Assert.AreEqual(licensePlateParserResult, expected);
        }

        [TestMethod]
        public void TestGetLicensePlate()
        {
            string licensePlateParserResult = licensePlateParser.GetLicensePlate("SBN2208 120 10:00");
            string expected = "SBN2208";
            Assert.AreEqual(licensePlateParserResult, expected);
        }

        [TestMethod]
        public void TestFormatAndValidateLicensePlate()
        {
            string licensePlateParserResult = licensePlateParser.FormatAndValidateLicensePlate("SBN 2208");
            string expected = "SBN2208";
            Assert.AreEqual(licensePlateParserResult, expected);
        }

        [TestMethod]
        public void TestFormatAndValidateLicensePlate2()
        {
            string licensePlateParserResult = licensePlateParser.FormatAndValidateLicensePlate("SBN2208");
            string expected = "SBN2208";
            Assert.AreEqual(licensePlateParserResult, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestFormatAndValidateLicensePlate2NotValid()
        {
            string licensePlateParserResult = licensePlateParser.FormatAndValidateLicensePlate("SBN208");

        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestFormatAndValidateLicensePlate2NotValid2()
        {
            string licensePlateParserResult = licensePlateParser.FormatAndValidateLicensePlate("SN2080");

        }
    }
}
