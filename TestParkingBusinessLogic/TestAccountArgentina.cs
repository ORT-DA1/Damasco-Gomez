using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingBusinessLogic;
using ParkingBusinessLogic.Exceptions;

namespace TestParkingBusinessLogic
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class TestAccountArgentina
    {
        private Account emptyAccount;
        private Account myAccount;
        [TestInitialize]
        public void initTest()
        {
            emptyAccount = new AccountArgentina();

        }

        [TestMethod]
        public void TestEmptyAccount()
        {
            emptyAccount = new AccountArgentina();
        }
        [TestMethod]
        public void TestValidateFormatNumTrue()
        {
            string num = "12-34-56-78";
            bool output = emptyAccount.ValidateFormatNum(num);
            Assert.IsTrue(output);
        }
        [TestMethod]
        public void TestValidateFormatNumTrue1()
        {
            string num = "1-2-3-4-5-6-7";
            bool output = emptyAccount.ValidateFormatNum(num);
            Assert.IsTrue(output);
        }
        [TestMethod]
        public void TestValidateFormatNumFalse()
        {
            string num = "12--345-6--7";
            bool output = emptyAccount.ValidateFormatNum(num);
            Assert.IsFalse(output);
            
        }
        [TestMethod]
        public void TestValidateFormatNumFalse2()
        {
            string num = "123--4567";
            bool output = emptyAccount.ValidateFormatNum(num);
            Assert.IsFalse(output);

        }
        [TestMethod]
        public void TestValidateFormatNumTrue3()
        {
            string num = "123456";
            bool output = emptyAccount.ValidateFormatNum(num);
            Assert.IsTrue(output);
        }
        [TestMethod]
        public void TestValidateFormatNumTrue4()
        {
            string num = "12345678   ";
            bool output = emptyAccount.ValidateFormatNum(num);
            Assert.IsTrue(output);
        }
        [TestMethod]
        public void TestValidateFormatNumFalse3()
        {
            string num = "letras";
            bool output = emptyAccount.ValidateFormatNum(num);
            Assert.IsFalse(output);
        }
        [TestMethod]
        public void TestValidateFormatNumFalse4()
        {
            string num = "123456789";
            bool output = emptyAccount.ValidateFormatNum(num);
            Assert.IsFalse(output);
        }
        [TestMethod]
        public void TestValidateFormatNumFalse5()
        {
            string num = "12345";
            bool output = emptyAccount.ValidateFormatNum(num);
            Assert.IsFalse(output);
        }
        [TestMethod]
        public void TestValidateFormatNumFalse6()
        {
            string num = "1-2-3-4-5 -6";
            bool output = emptyAccount.ValidateFormatNum(num);
            Assert.IsFalse(output);
        }
        [TestMethod]
        public void TestValidateFormatNumFalse7()
        {
            string num = "1 2 3 4 5 6";
            bool output = emptyAccount.ValidateFormatNum(num);
            Assert.IsFalse(output);
        }
        [TestMethod]
        public void TestValidateFormatNumFalse8()
        {
            string num = "1234567 8";
            bool output = emptyAccount.ValidateFormatNum(num);
            Assert.IsFalse(output);
        }
        [TestMethod]
        public void TestValidateFormatNumFalse9()
        {
            string num = "123-45 6-78";
            bool output = emptyAccount.ValidateFormatNum(num);
            Assert.IsFalse(output);
        }
        [TestMethod]
        public void TestValidateFormatNum()
        {
            string num = "123-456-78";
            string output = emptyAccount.FormatNum(num);
            string expected = "12345678";
            Assert.AreEqual(output,expected);
        }
        [TestMethod]
        public void TestValidateFormatNum1()
        {
            string num = "1-2-3-4-5-6-7";
            string output = emptyAccount.FormatNum(num);
            string expected = "1234567";
            Assert.AreEqual(output, expected);
        }
        [TestMethod]
        public void TestValidateFormatNum2()
        {
            string num = "123-456";
            string output = emptyAccount.FormatNum(num);
            string expected = "123456";
            Assert.AreEqual(output, expected);
        }
        [TestMethod]
        public void TestValidateFormatNum3()
        {
            string num = "    123-456-78  ";
            string output = emptyAccount.FormatNum(num);
            string expected = "12345678";
            Assert.AreEqual(output, expected);
        }
        [TestMethod]
        public void TestValidateFormatNum4()
        {
            string num = "   123456-7";
            string output = emptyAccount.FormatNum(num);
            string expected = "1234567";
            Assert.AreEqual(output, expected);
        }
        [TestMethod]
        public void TestValidateFormatNum5()
        {
            string num = "12-3-456   ";
            string output = emptyAccount.FormatNum(num);
            string expected = "123456";
            Assert.AreEqual(output, expected);
        }
        [TestMethod]
        public void TestCreateAccount()
        {
            string num = "12-3-456   ";
            string balance = "100";
            myAccount = new AccountArgentina(num, balance);
        }
        [TestMethod]
        public void TestCreateAccount1()
        {
            string num = "12-3-4567   ";
            string balance = "100";
            myAccount = new AccountArgentina(num, balance);
        }
        [TestMethod]
        public void TestCreateAccount2()
        {
            string num = "12-3-45-6-7-8  ";
            string balance = "100";
            myAccount = new AccountArgentina(num, balance);
        }
        [TestMethod]
        public void TestCreateAccount3()
        {
            string num = "    1-2-3-4-56   ";
            string balance = "100";
            myAccount = new AccountArgentina(num, balance);
        }
        [TestMethod]
        public void TestCreateAccount4()
        {
            string num = "   12-3-456-7   ";
            string balance = "100";
            myAccount = new AccountArgentina(num, balance);
        }
        [TestMethod]
        public void TestCreateAccount5()
        {
            string num = "   12-3-45678   ";
            string balance = "100";
            myAccount = new AccountArgentina(num, balance);
        }
        [TestMethod]
        public void TestCreateAccount6()
        {
            string num = "  1-2-3-456";
            string balance = "100";
            myAccount = new AccountArgentina(num, balance);
        }
        [TestMethod]
        public void TestCreateAccount7()
        {
            string num = "   12-3-4567";
            string balance = "100";
            myAccount = new AccountArgentina(num, balance);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidAccountArgentinaException))]
        public void TestCantCreateAccount8()
        {
            string num = "1 2-3-4567";
            string balance = "100";
            myAccount = new AccountArgentina(num, balance);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidAccountArgentinaException))]
        public void TestCantCreateAccount9()
        {
            string num = "12--3-4567";
            string balance = "100";
            myAccount = new AccountArgentina(num, balance);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidAccountArgentinaException))]
        public void TestCantCreateAccount10()
        {
            string num = "12-3-45--67";
            string balance = "100";
            myAccount = new AccountArgentina(num, balance);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidAccountArgentinaException))]
        public void TestCantCreateAccount11()
        {
            string num = "12-3-4567";
            string balance = "-100";
            myAccount = new AccountArgentina(num, balance);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidAccountArgentinaException))]
        public void TestCantCreateAccount12()
        {
            string num = "12-3-4567";
            string balance = "0";
            myAccount = new AccountArgentina(num, balance);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidAccountArgentinaException))]
        public void TestCantCreateAccount13()
        {
            string num = "12-3-45 67";
            string balance = "100";
            myAccount = new AccountArgentina(num, balance);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidAccountArgentinaException))]
        public void TestCantCreateAccount14()
        {
            string num = "12-3-4567";
            string balance = "letras";
            myAccount = new AccountArgentina(num, balance);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidAccountArgentinaException))]
        public void TestCantCreateAccount15()
        {
            string num = "12-3-456789";
            string balance = "100";
            myAccount = new AccountArgentina(num, balance);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidAccountArgentinaException))]
        public void TestCantCreateAccount16()
        {
            string num = "12-3-    4567";
            string balance = "100";
            myAccount = new AccountArgentina(num, balance);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidAccountArgentinaException))]
        public void TestCantCreateAccount17()
        {
            string num = "12-3-4f567";
            string balance = "100";
            myAccount = new AccountArgentina(num, balance);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidAccountArgentinaException))]
        public void TestCantCreateAccount18()
        {
            string num = "-12234567-";
            string balance = "100";
            myAccount = new AccountArgentina(num, balance);
        }
    }
}
