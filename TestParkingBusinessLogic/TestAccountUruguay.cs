using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;
using ParkingBusinessLogic.Exceptions;
using System;
using System.Diagnostics.CodeAnalysis;

namespace TestParkingBusinessLogic
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class TestAccountUruguay
    {
        public Account myAccount;

        [TestInitialize]
        public void InitAccount()
        {
            myAccount = new AccountUruguay("098456783", "110");
        }


        [TestMethod]
        public void TestAddBalanceCorrect()
        {
            bool output = myAccount.AddBalance(200);
            Assert.IsTrue(output);
        }

        [TestMethod]
        [ExpectedException(typeof(NegativeNumberException))]
        public void TestAddBalanceNegativeNumber()
        {
            myAccount.AddBalance(-200);
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidAccountUruguayException))]
        public void TestValidateFormatFalse1()
        {
            String num = "9f03uf134";
            myAccount = new AccountUruguay(num, "0");

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidAccountUruguayException))]
        public void TestValidateFormatFalse2()
        {
            string num = "19042";
            myAccount = new AccountUruguay(num, "0");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidAccountUruguayException))]
        public void TestValidateFormatFalse3()
        {
            string num = "093457869";
            myAccount = new AccountUruguay(num, "0");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidAccountUruguayException))]
        public void TestValidateFormatFalse4()
        {
            string num = "0998473647875";
            myAccount = new AccountUruguay(num, "0");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidAccountUruguayException))]
        public void TestValidateFormatFalse5()
        {
            string num = "095 77 88 99 34";
            Account myAccount = new AccountUruguay(num, "0");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidAccountUruguayException))]
        public void TestValidateFormatFalse6()
        {
            string num = " 09577889934 ";
            myAccount = new AccountUruguay(num, "0");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidAccountUruguayException))]
        public void TestValidateFormatFalse7()
        {
            string num = "098893898";
            myAccount = new AccountUruguay(num, "-150");
        }


        [TestMethod]
        public void TestValidateFormatTrue1()
        {
            string num = "99673647";
            myAccount = new AccountUruguay(num, "110");
            string output = myAccount.Number;
            string expected = "99 673 647";

            Assert.AreEqual(output, expected);
        }

        [TestMethod]

        public void TestValidateFormatTrue2()
        {
            string num = "099673647";
            myAccount = new AccountUruguay(num, "110");
            string output = myAccount.Number;
            string expected = "099 673 647";

            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestValidateFormatTrue3()
        {
            string num = "99 67 364 7";
            myAccount = new AccountUruguay(num, "110");
            string output = myAccount.Number;
            string expected = "99 673 647";

            Assert.AreEqual(output, expected);
        }
        [TestMethod]
        public void TestValidateFormatTrue4()
        {
            string num = "   99673647  ";
            myAccount = new AccountUruguay(num, "110");
            string output = myAccount.Number;
            string expected = "99 673 647";

            Assert.AreEqual(output, expected);
        }
        [TestMethod]
        public void TestValidateFormatTrue5()
        {
            string num = "09 96 73 6 47";
            myAccount = new AccountUruguay(num, "110");
            string output = myAccount.Number;
            string expected = "099 673 647";

            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestEnoughBalance()
        {
            myAccount = new AccountUruguay("098878989", "200");
            bool output = myAccount.EnoughBalance(99);

            Assert.IsTrue(output);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidAccountUruguayException))]
        public void TestValidateFormatNum()
        {
            string numer = " 095 778 899 348 8965 ";
            myAccount.FormatNum(numer);
        }

        [TestMethod]
        public void TestNotEnoughBalance()
        {
            myAccount = new AccountUruguay("098878989", "98");
            bool output = myAccount.EnoughBalance(99);
            Assert.IsFalse(output);
        }

        [TestMethod]
        public void TestDiscountBalancePositiveNumberandEnoughBalance()
        {
            myAccount = new AccountUruguay("098878989", "300");
            int amount = 200;
            bool output = myAccount.DiscountBalance(amount);
            Assert.IsTrue(output);
        }

        [TestMethod]
        [ExpectedException(typeof(InsufficientBalanceException))]
        public void TestDiscountBalancePositiveNumberandInsufficientBalance()
        {
            myAccount = new AccountUruguay("098878989", "100");
            int amount = 200;
            bool output = myAccount.DiscountBalance(amount);


        }

        [TestMethod]
        [ExpectedException(typeof(NegativeNumberException))]
        public void TestDiscountBalanceNegativeNumber()
        {
            myAccount = new AccountUruguay("098878989", "100");
            int amount = -50;
            bool output = myAccount.DiscountBalance(amount);

        }
       




    }



}
