using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;
using ParkingBusinessLogic.Exceptions;
using System;
using System.Diagnostics.CodeAnalysis;

namespace TestParkingBusinessLogic
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class TestDateParser
    {
        private DateParser dateParser;
        [TestInitialize]
        public void InitTest()
        {
            dateParser = new DateParser();
        }

        [TestMethod]
        public void TestParserTimeFromCheckOk()
        {
            string checkMsg = "  14/10 13:00";
            string output = dateParser.ParserTimeFromCheck(checkMsg);
            string expected = "13:00";
            Assert.AreEqual(expected, output);
        }
        [TestMethod]
        public void TestParserTimeFromCheckFail()
        {
            string checkMsg = "notValid";
            string output = dateParser.ParserTimeFromCheck(checkMsg);
            string expected = "";
            Assert.AreEqual(expected, output);
        }
        [TestMethod]
        public void TestParserTimeFromTxt1()
        {
            string txt = "SBD1345 120 13:00";
            string output = dateParser.ParserTimeFromTxt(txt);
            string expected = "13:00";
            Assert.AreEqual(expected, output);
        }
        [TestMethod]
        public void TestParserTimeFromTxt2()
        {
            string txt = "SBD 1345 120 13:00";
            string output = dateParser.ParserTimeFromTxt(txt);
            string expected = "13:00";
            Assert.AreEqual(expected, output);
        }
        [TestMethod]
        public void TestParserTimeFromTxt3()
        {
            string txt = "SBD1345 120";
            string output = dateParser.ParserTimeFromTxt(txt);
            string expected = DateTime.Now.ToString("HH:mm");
            Assert.AreEqual(expected, output);
        }
        [TestMethod]
        public void TestParserTimeFromTxtFail()
        {
            string txt = "SBD345 120";
            string output = dateParser.ParserTimeFromTxt(txt);
            string expected = "";
            Assert.AreEqual(expected, output);
        }
        [TestMethod]
        public void TestParserTimeFromTxtFail2()
        {
            string txt = "SBD1345 10";
            string output = dateParser.ParserTimeFromTxt(txt);
            string expected = "";
            Assert.AreEqual(expected, output);
        }
        [TestMethod]
        public void TestParserDayOk()
        {
            string checkMsg = "14/10 13:00 ";
            string output = dateParser.ParserDayFromCheck(checkMsg);
            string expected = "14/10";
            Assert.AreEqual(expected, output);
        }
        [TestMethod]
        public void TestParserDayFail()
        {
            string checkMsg = "notValid";
            string output = dateParser.ParserDayFromCheck(checkMsg);
            string expected = "";
            Assert.AreEqual(expected, output);
        }
        [TestMethod]
        public void TestValidateTimeOk()
        {
            string timeIn = "13:00";
            Assert.IsTrue(dateParser.ValidateTime(timeIn));
        }

        [TestMethod]
        public void TestValidateTimeFaild()
        {
            string timeIn = "19:00";
            Assert.IsFalse(dateParser.ValidateTime(timeIn));
        }
        [TestMethod]
        public void TestValidateTimeFaild2()
        {
            string timeIn = "9:00";
            Assert.IsFalse(dateParser.ValidateTime(timeIn));
        }

        [TestMethod]
        public void TestValidateTimeFaild3()
        {
            string timeIn = "bananas";
            Assert.IsFalse(dateParser.ValidateTime(timeIn));
        }

        [TestMethod]
        public void TestValidateDateNumberFail()
        {
            string MyDay = "55";
            string MyMonth = "1";
            Assert.IsFalse(dateParser.ValidateDateNumberFromCheck(MyMonth, MyDay));
        }
        [TestMethod]
        public void TestValidateDateNumberFail1()
        {
            string MyDay = "1";
            string MyMonth = "55";
            Assert.IsFalse(dateParser.ValidateDateNumberFromCheck(MyMonth, MyDay));
        }
        [TestMethod]
        public void TestValidateDateNumberFail2()
        {
            string MyDay = "55";
            string MyMonth = "55";
            Assert.IsFalse(dateParser.ValidateDateNumberFromCheck(MyMonth, MyDay));
        }

        [TestMethod]
        public void TestValidateDateNumberOk()
        {
            string MyDay = "1";
            string MyMonth = "1";
            Assert.IsTrue(dateParser.ValidateDateNumberFromCheck(MyMonth, MyDay));
        }
        [TestMethod]
        public void TestValidateNumberArray()
        {
            string[] input = { "2", "4", "5", "8" };
            Assert.IsTrue(dateParser.ValidateNumberArrayFromCheck(input));
        }
        [TestMethod]
        public void TestValidateNumberArray1()
        {
            string[] input = { "3", "4", "b" };
            Assert.IsFalse(dateParser.ValidateNumberArrayFromCheck(input));
        }
        [TestMethod]
        public void TestValidateNumberArray2()
        {
            string[] input = { "b", "b", "b" };
            Assert.IsFalse(dateParser.ValidateNumberArrayFromCheck(input));
        }
        [TestMethod]
        public void TestValidateDayOk()
        {
            string input = "1/1";
            Assert.IsTrue(dateParser.ValidateDayFromCheck(input));
        }
        [TestMethod]
        public void TestValidateDayFalse()
        {
            string input = "12/12";
            Assert.IsFalse(dateParser.ValidateDayFromCheck(input));
        }
        [TestMethod]
        public void TestValidateDayFalse1()
        {
            string input = "55/12";
            Assert.IsFalse(dateParser.ValidateDayFromCheck(input));
        }
        [TestMethod]
        public void TestValidateDayFalse2()
        {
            string input = "11/22/44";
            Assert.IsFalse(dateParser.ValidateDayFromCheck(input));
        }
        [TestMethod]
        public void TestValidateDayFalse3()
        {
            string input = "11/28";
            Assert.IsFalse(dateParser.ValidateDayFromCheck(input));
        }
        [TestMethod]
        public void TestValidateDayFalse4()
        {
            string input = "a/b";
            Assert.IsFalse(dateParser.ValidateDayFromCheck(input));
        }

        [TestMethod]
        public void TestValidateDayFail()
        {
            string input = "novalido";
            Assert.IsFalse(dateParser.ValidateDayFromCheck(input));
        }
        [TestMethod]
        public void TestFormatDay()
        {
            string input = "11/11";
            string expected = "11-11";
            string output = dateParser.FormatDayFromCheck(input);
            Assert.AreEqual(expected, output);
        }
        [TestMethod]
        public void TestGetTimeFromCheckOk()
        {
            string input = "1/10 12:00";
            string expected = "12:00";
            string output = dateParser.GetTimeFromCheck(input);
            Assert.AreEqual(expected, output);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextCheckException))]
        public void TestGetTimeFromCheckFail()
        {
            string input = "thisIs Trash";
            string output = dateParser.GetTimeFromCheck(input);
        }
        [TestMethod]
        public void TestGetTimeFromTxtOk()
        {
            string input = "SBD1234 120 12:00";
            string expected = "12:00";
            string output = dateParser.GetTimeFromTxt(input);
            Assert.AreEqual(expected, output);
        }
        [TestMethod]
        public void TestGetTimeNow()
        {
            string input = "SBD 1234 120 ";
            string expected = DateTime.Now.ToString("HH:mm");
            string output = dateParser.ParserTimeFromTxt(input);
            Assert.AreEqual(expected, output);
        }
        [TestMethod]
        public void TestGetTimeNowLicensePlateInvalid()
        {
            string input = "SB 1234 120 ";
            string output = dateParser.ParserTimeFromTxt(input);
            string expected = "";
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void TestGetTimeNowCantMinutesInvalid()
        {
            string input = "SBN 1234 147 ";
            string output = dateParser.ParserTimeFromTxt(input);
            string expected = "";
            Assert.AreEqual(expected, output);

        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void TestGetTimeFromTxtFail()
        {
            string input = "SB 123 147";
            string output = dateParser.GetTimeFromTxt(input);
        }
        [TestMethod]
        public void TestGetDayFromCheckOk()
        {
            string input = "01/01 12:00";
            string expected = "01-01";
            string output = dateParser.GetDayFromCheck(input);
            Assert.AreEqual(expected, output);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextCheckException))]
        public void TestGetDayFromCheckFail()
        {
            string input = "101/101 12:00";
            string output = dateParser.GetDayFromCheck(input);
        }
    }
}
