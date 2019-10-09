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
            string licensePlateParserResult= licensePlateParser.ValidateLicensePlate("SBN2208");
            string expected = "SBN2208";
            Assert.AreEqual(licensePlateParserResult, expected);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestValidateLicensePlateOk2()
        {
            string licensePlateParserResult = licensePlateParser.ValidateLicensePlate("");
           
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        
        public void TestValidateLicensePlateNotValid()
        {
            string licensePlateParserResult = licensePlateParser.ValidateLicensePlate("SBN24234232208");
            
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]

        public void TestValidateLicensePlateNotValid2()
        {
            string licensePlateParserResult = licensePlateParser.ValidateLicensePlate("SN2208");

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]

        public void TestValidateLicensePlateNotValid3()
        {
            string licensePlateParserResult = licensePlateParser.ValidateLicensePlate("SNB08");

        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]

        public void TestValidateLicensePlateNotValid4()
        {
            string licensePlateParserResult = licensePlateParser.ValidateLicensePlate("SNB");

        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]

        public void TestValidateLicensePlateNotValid5()
        {
            string licensePlateParserResult = licensePlateParser.ValidateLicensePlate("3456");

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

        

    }
}
