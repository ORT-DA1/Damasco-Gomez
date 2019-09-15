using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;

namespace TestParkingBusinessLogic
{
    [TestClass]
    public class TestAccount
    {

        Account myAccount;

        [TestInitialize]
        public void testInit()
        {
            myAccount = new Account();
        }

        [TestMethod]
        public void testAddBalance()
        {
            Boolean output = myAccount.addBalance();

            Assert.IsTrue(output);
        }

        [TestMethod]
        public void testValidateFormatFalse1()
        {
            String num = "9f03uf134";
            String expected = "Formato Invalido";
            String output = myAccount.validateFormat(num);

            Assert.AreEqual(output,expected);
        }

        [TestMethod]
        public void testValidateFormatFalse2()
        {
            String num = "19042";
            String expected = "Formato Invalido";
            String output = myAccount.validateFormat(num);

            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void testValidateFormatFalse3()
        {
            String num = "093457869";
            String expected = "Formato Invalido";
            String output = myAccount.validateFormat(num);

            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void testValidateFormatFalse4()
        {
            String num = "0998473647875";
            String expected = "Formato Invalido";
            String output = myAccount.validateFormat(num);

            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void testValidateFormatFalse5()
        {
            String num = "095 77 88 99 34";
            String expected = "Formato Invalido";
            String output = myAccount.validateFormat(num);

            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void testValidateFormatFalse6()
        {
            String num = " 09577889934 ";
            String expected = "Formato Invalido";
            String output = myAccount.validateFormat(num);

            Assert.AreEqual(output, expected);
        }


        [TestMethod]
        public void testValidateFormatTrue1()
        {
            String num = "99673647";
            String output = myAccount.validateFormat(num);
            String expected = "99 673 647";

            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void testValidateFormatTrue2()
        {
            String num = "099673647";
            String output = myAccount.validateFormat(num);
            String expected = "099 673 647";

            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void testValidateFormatTrue3()
        {
            String num = "99 67 364 7";
            String output = myAccount.validateFormat(num);
            String expected = "99 673 647";

            Assert.AreEqual(output, expected);
        }
        [TestMethod]
        public void testValidateFormatTrue4()
        {
            String num = "   99673647  ";
            String output = myAccount.validateFormat(num);
            String expected = "99 673 647";

            Assert.AreEqual(output, expected);
        }
        [TestMethod]
        public void testValidateFormatTrue5()
        {
            String num = "09 96 73 6 47";
            String output = myAccount.validateFormat(num);
            String expected = "099 673 647";

            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void testEnoughBalance()
        {
            Boolean output = myAccount.enoughBalance();

            Assert.IsTrue(output);
        }

    }

   
}
