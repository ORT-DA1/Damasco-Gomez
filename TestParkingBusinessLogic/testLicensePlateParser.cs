using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;
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
    }
}
