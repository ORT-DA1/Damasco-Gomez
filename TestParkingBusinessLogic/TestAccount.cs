using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;
using ParkingBusinessLogic.Exceptions;

namespace TestParkingBusinessLogic
{
    [TestClass]
    public class TestAccount
    {

        [TestInitialize]
        public void TestInit()
        {
        }

        [TestMethod]
        public void TestAddBalance()
        {
            Account myAccount = new Account("099897989");
            Boolean output = myAccount.AddBalance();

            Assert.IsTrue(output);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidNumberException))]
        public void TestValidateFormatFalse1()
        {
            String num = "9f03uf134";
            Account myAccount = new Account(num);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidNumberException))]
        public void TestValidateFormatFalse2()
        {
            String num = "19042";
            Account myAccount = new Account(num);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidNumberException))]
        public void TestValidateFormatFalse3()
        {
            String num = "093457869";
            Account myAccount = new Account(num);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidNumberException))]
        public void TestValidateFormatFalse4()
        {
            String num = "0998473647875";
            Account myAccount = new Account(num);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidNumberException))]
        public void TestValidateFormatFalse5()
        {
            String num = "095 77 88 99 34";
            Account myAccount = new Account(num);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidNumberException))]
        public void TestValidateFormatFalse6()
        {
            String num = " 09577889934 ";
            Account myAccount = new Account(num);
        }


        [TestMethod]
        public void TestValidateFormatTrue1()
        {
            String num = "99673647";
            Account myAccount = new Account(num);
            String output = myAccount.Number;
            String expected = "99 673 647";

            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        //[ExpectedException(typeof(InvalidFormatException))]
        public void TestValidateFormatTrue2()
        {
            String num = "099673647";
            Account myAccount = new Account(num);
            String output = myAccount.Number;
            String expected = "099 673 647";

            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestValidateFormatTrue3()
        {
            String num = "99 67 364 7";
            Account myAccount = new Account(num);
            String output = myAccount.Number;
            String expected = "99 673 647";

            Assert.AreEqual(output, expected);
        }
        [TestMethod]
        public void TestValidateFormatTrue4()
        {
            String num = "   99673647  ";
            Account myAccount = new Account(num);
            String output = myAccount.Number;
            String expected = "99 673 647";

            Assert.AreEqual(output, expected);
        }
        [TestMethod]
        public void TestValidateFormatTrue5()
        {
            String num = "09 96 73 6 47";
            Account myAccount = new Account(num);
            String output = myAccount.Number;
            String expected = "099 673 647";

            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestEnoughBalance()
        {
            Account myAccount = new Account("098878989");
            Boolean output = myAccount.EnoughBalance();

            Assert.IsTrue(output);
        }

    }
    [TestMethod]
    public void DiscountBalance()
    {
        int amount = 200;
        Boolean output = myAccount.DiscountBalance(amount);
        Assert.IsTrue(output);
    }


}
