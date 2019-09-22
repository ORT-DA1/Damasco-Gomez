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
        public void TestInit()
        {
            myAccount = new Account();
        }

        [TestMethod]
        public void TestAddBalance()
        {
            Boolean output = myAccount.AddBalance();

            Assert.IsTrue(output);
        }

        [TestMethod]
        public void TestValidateFormatFalse1()
        {
            String num = "9f03uf134";
            String expected = "Formato Invalido";
            String output = myAccount.ValidateFormat(num);

            Assert.AreEqual(output,expected);
        }

        [TestMethod]
        public void TestValidateFormatFalse2()
        {
            String num = "19042";
            String expected = "Formato Invalido";
            String output = myAccount.ValidateFormat(num);

            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestValidateFormatFalse3()
        {
            String num = "093457869";
            String expected = "Formato Invalido";
            String output = myAccount.ValidateFormat(num);

            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestValidateFormatFalse4()
        {
            String num = "0998473647875";
            String expected = "Formato Invalido";
            String output = myAccount.ValidateFormat(num);

            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestValidateFormatFalse5()
        {
            String num = "095 77 88 99 34";
            String expected = "Formato Invalido";
            String output = myAccount.ValidateFormat(num);

            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestValidateFormatFalse6()
        {
            String num = " 09577889934 ";
            String expected = "Formato Invalido";
            String output = myAccount.ValidateFormat(num);

            Assert.AreEqual(output, expected);
        }


        [TestMethod]
        public void TestValidateFormatTrue1()
        {
            String num = "99673647";
            String output = myAccount.ValidateFormat(num);
            String expected = "99 673 647";

            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        //[ExpectedException(typeof(InvalidFormatException))]
        public void TestValidateFormatTrue2()
        {
            String num = "099673647";
            String output = myAccount.ValidateFormat(num);
            String expected = "099 673 647";

            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestValidateFormatTrue3()
        {
            String num = "99 67 364 7";
            String output = myAccount.ValidateFormat(num);
            String expected = "99 673 647";

            Assert.AreEqual(output, expected);
        }
        [TestMethod]
        public void TestValidateFormatTrue4()
        {
            String num = "   99673647  ";
            String output = myAccount.ValidateFormat(num);
            String expected = "99 673 647";

            Assert.AreEqual(output, expected);
        }
        [TestMethod]
        public void TestValidateFormatTrue5()
        {
            String num = "09 96 73 6 47";
            String output = myAccount.ValidateFormat(num);
            String expected = "099 673 647";

            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestEnoughBalance()
        {
            Boolean output = myAccount.EnoughBalance();

            Assert.IsTrue(output);
        }

    }

   
}
