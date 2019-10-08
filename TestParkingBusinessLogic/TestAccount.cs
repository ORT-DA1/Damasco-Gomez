using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;
using ParkingBusinessLogic.Exceptions;

namespace TestParkingBusinessLogic
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class TestAccount
    {

        [TestInitialize]
       

        [TestMethod]
        public void TestAddBalanceCorrect()
        {

            Account myAccount = new Account("098456783", 0);
            bool output = myAccount.AddBalance(200);

            Assert.IsTrue(output);
        }
        [TestMethod]
        [ExpectedException(typeof(NegativeNumberException))]
        public void TestAddBalanceNegativeNumber()
        {

            Account myAccount = new Account("098456783", 0);
            myAccount.AddBalance(-200);
            
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidNumberException))]
        public void TestValidateFormatFalse1()
        {
            String num = "9f03uf134";
            Account myAccount = new Account(num, 0);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidNumberException))]
        public void TestValidateFormatFalse2()
        {
            string num = "19042";
            Account myAccount = new Account(num, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidNumberException))]
        public void TestValidateFormatFalse3()
        {
            string num = "093457869";
            Account myAccount = new Account(num, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidNumberException))]
        public void TestValidateFormatFalse4()
        {
            string num = "0998473647875";
            Account myAccount = new Account(num, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidNumberException))]
        public void TestValidateFormatFalse5()
        {
            string num = "095 77 88 99 34";
            Account myAccount = new Account(num, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidNumberException))]
        public void TestValidateFormatFalse6()
        {
            string num = " 09577889934 ";
            Account myAccount = new Account(num, 0);
        }


        [TestMethod]
        public void TestValidateFormatTrue1()
        {
            string num = "99673647";
            Account myAccount = new Account(num,0);
            string output = myAccount.Number;
            string expected = "99 673 647";

            Assert.AreEqual(output, expected);
        }

        [TestMethod]
     
        public void TestValidateFormatTrue2()
        {
            string num = "099673647";
            Account myAccount = new Account(num, 0);
            string output = myAccount.Number;
            string expected = "099 673 647";

            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestValidateFormatTrue3()
        {
            string num = "99 67 364 7";
            Account myAccount = new Account(num, 0);
            string output = myAccount.Number;
            string expected = "99 673 647";

            Assert.AreEqual(output, expected);
        }
        [TestMethod]
        public void TestValidateFormatTrue4()
        {
            string num = "   99673647  ";
            Account myAccount = new Account(num, 0);
            string output = myAccount.Number;
            string expected = "99 673 647";

            Assert.AreEqual(output, expected);
        }
        [TestMethod]
        public void TestValidateFormatTrue5()
        {
            string num = "09 96 73 6 47";
            Account myAccount = new Account(num,0);
            string output = myAccount.Number;
            string expected = "099 673 647";

            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestEnoughBalance()
        {
            Account myAccount = new Account("098878989",200);
            bool output = myAccount.EnoughBalance(99);

            Assert.IsTrue(output);
        }

        [TestMethod]
        public void TestNotEnoughBalance()
        {
            Account myAccount = new Account("098878989", 98);
            bool output = myAccount.EnoughBalance(99);
            Assert.IsFalse(output);
        }

        [TestMethod]
        public void TestDiscountBalancePositiveNumberandEnoughBalance()
        {
            Account myAccount = new Account("098878989",300);
            int amount = 200;
            bool output = myAccount.DiscountBalance(amount);
            Assert.IsTrue(output);
        }

        [TestMethod]
        [ExpectedException(typeof(InsufficientBalanceException))]
        public void TestDiscountBalancePositiveNumberandInsufficientBalance()
        {
            Account myAccount = new Account("098878989", 100);
            int amount = 200;
            bool output = myAccount.DiscountBalance(amount);
            
        }

        [TestMethod]
        [ExpectedException(typeof(NegativeNumberException))]
        public void TestDiscountBalanceNegativeNumber()
        {
            Account myAccount = new Account("098878989", 100);
            int amount = -50;
            bool output = myAccount.DiscountBalance(amount);

        }
        [TestMethod]
        public void TestAccountEmpty()
        {

            Account myAccount = new Account();
            bool expected = myAccount.AccountEmpty();
            Assert.IsTrue(expected);
        }




    }



}
