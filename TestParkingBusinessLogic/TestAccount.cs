using System;
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
        public void TestInit()
        {
        }

        [TestMethod]
        public void TestAddBalanceCorrect()
        {

            Account myAccount = new Account("098456783");
            bool output = myAccount.AddBalance(myAccount, 200);

            Assert.IsTrue(output);
        }
        public void TestAddBalanceNegativeNumber()
        {

            Account myAccount = new Account("098456783");
            bool output = myAccount.AddBalance(myAccount, 200);
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
            string num = "19042";
            Account myAccount = new Account(num);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidNumberException))]
        public void TestValidateFormatFalse3()
        {
            string num = "093457869";
            Account myAccount = new Account(num);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidNumberException))]
        public void TestValidateFormatFalse4()
        {
            string num = "0998473647875";
            Account myAccount = new Account(num);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidNumberException))]
        public void TestValidateFormatFalse5()
        {
            string num = "095 77 88 99 34";
            Account myAccount = new Account(num);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidNumberException))]
        public void TestValidateFormatFalse6()
        {
            string num = " 09577889934 ";
            Account myAccount = new Account(num);
        }


        [TestMethod]
        public void TestValidateFormatTrue1()
        {
            string num = "99673647";
            Account myAccount = new Account(num);
            string output = myAccount.Number;
            string expected = "99 673 647";

            Assert.AreEqual(output, expected);
        }

        [TestMethod]
     
        public void TestValidateFormatTrue2()
        {
            string num = "099673647";
            Account myAccount = new Account(num);
            string output = myAccount.Number;
            string expected = "099 673 647";

            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestValidateFormatTrue3()
        {
            string num = "99 67 364 7";
            Account myAccount = new Account(num);
            string output = myAccount.Number;
            string expected = "99 673 647";

            Assert.AreEqual(output, expected);
        }
        [TestMethod]
        public void TestValidateFormatTrue4()
        {
            string num = "   99673647  ";
            Account myAccount = new Account(num);
            string output = myAccount.Number;
            string expected = "99 673 647";

            Assert.AreEqual(output, expected);
        }
        [TestMethod]
        public void TestValidateFormatTrue5()
        {
            string num = "09 96 73 6 47";
            Account myAccount = new Account(num);
            string output = myAccount.Number;
            string expected = "099 673 647";

            Assert.AreEqual(output, expected);
        }

        [TestMethod]
        public void TestEnoughBalance()
        {
            Account myAccount = new Account("098878989");
            bool output = myAccount.EnoughBalance();

            Assert.IsTrue(output);
        }
        [TestMethod]
        public void DiscountBalance()
        {
            Account myAccount = new Account("098878989");
            int amount = 200;
            bool output = myAccount.DiscountBalance(amount);
            Assert.IsTrue(output);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void askforParking()
        {   
            string num = ("098 87 89 89");
            Account myAccount = new Account(num);
            string msg = ("jyjtgytjh");
            myAccount.AskforParking(num,msg);


        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void validateMsgIncorrect()
        {
            string num = ("098 87 89 89");
            Account myAccount = new Account(num);
            string msg = ("SB1234 1234");
            myAccount.validateMsg(msg);


        }
        [TestMethod]
       
        public void validateMsgCorrect()
        {
            string num = ("098 87 89 89");
            Account myAccount = new Account(num);
            string msg = ("SBS1234 150 10:15");
            bool output = myAccount.validateMsg(msg);
            Assert.IsTrue(output);


        }
        [TestMethod]

        public void validateHoursMultiple30()
        {
            string num = ("098 87 89 89");
            Account myAccount = new Account(num);
            string msg = ("SBS1234 150 10:15");
            bool output = myAccount.validateMsg(msg);
            Assert.IsTrue(output);


        }

        [TestMethod]

        [ExpectedException(typeof(InvalidTextException))]
        public void  validateHoursNotMultiple30()
        {
            string num = ("098 87 89 89");
            Account myAccount = new Account(num);
            string msg = ("SBS1234 153 10:15");
            myAccount.validateMsg(msg);
         
           


        }
        [TestMethod]

        public void validateTimeInMsgCorrect()
        {
            string num = ("098 87 89 89");
            Account myAccount = new Account(num);
            string expected = "10:15";
            string output = myAccount.validateStartTime(expected);
            Assert.AreEqual(output, expected);



        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void validateTimeInMsgIncorrect()
        {
            string num = ("098 87 89 89");
            Account myAccount = new Account(num);
            string expected = "19:15";
            string output = myAccount.validateStartTime(expected);




        }
        [TestMethod]
       
        public void breakdownlicensePlateCorrect()
        {
            string num = ("098 87 89 89");
            Account myAccount = new Account(num);
            string msg = ("ABC 1234 60 10:00");
            string output = myAccount.breakDownLicensePlate(msg);
            string expected = "ABC 1234";
            Assert.AreEqual(output, expected);




        }

        public void breakdownCantMinutesCorrect()
        {
            string num = ("098 87 89 89");
            Account myAccount = new Account(num);
            string msg = ("ABC 1234 60 10:00");
            string output = myAccount.breakDownCantMinutes(msg);
            string expected = "60";
            Assert.AreEqual(output, expected);




        }
        public void breakdownHoursCorrect()
        {
            string num = ("098 87 89 89");
            Account myAccount = new Account(num);
            string msg = ("ABC 1234 60 10:00");
            string output = myAccount.breakDownHours(msg);
            string expected = "10:00";
            Assert.AreEqual(output, expected);




        }
    }



}
