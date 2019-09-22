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
        [TestMethod]
        public void DiscountBalance()
        {
            Account myAccount = new Account("098878989");
            int amount = 200;
            Boolean output = myAccount.DiscountBalance(amount);
            Assert.IsTrue(output);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void askforParking()
        {   
            String num = ("098 87 89 89");
            Account myAccount = new Account(num);
            String msg = ("jyjtgytjh");
            myAccount.AskforParking(num,msg);


        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void validateMsgIncorrect()
        {
            String num = ("098 87 89 89");
            Account myAccount = new Account(num);
            String msg = ("SB1234 1234");
            myAccount.validateMsg(msg);


        }
        [TestMethod]
       
        public void validateMsgCorrect()
        {
            String num = ("098 87 89 89");
            Account myAccount = new Account(num);
            String msg = ("SBS1234 150 10:15");
            Boolean output= myAccount.validateMsg(msg);
            Assert.IsTrue(output);


        }
        [TestMethod]

        public void validateHoursMultiple30()
        {
            String num = ("098 87 89 89");
            Account myAccount = new Account(num);
            String msg = ("SBS1234 150 10:15");
            Boolean output = myAccount.validateMsg(msg);
            Assert.IsTrue(output);


        }

        [TestMethod]

        [ExpectedException(typeof(InvalidTextException))]
        public void  validateHoursNotMultiple30()
        {
            String num = ("098 87 89 89");
            Account myAccount = new Account(num);
            String msg = ("SBS1234 153 10:15");
            myAccount.validateMsg(msg);
         
           


        }
        [TestMethod]

        public void validateTimeInMsgCorrect()
        {
            String num = ("098 87 89 89");
            Account myAccount = new Account(num);
            String expected = "10:15";
            String output = myAccount.validateStartTime(expected);
            Assert.AreEqual(output, expected);



        }
        [TestMethod]
        [ExpectedException(typeof(InvalidTextException))]
        public void validateTimeInMsgIncorrect()
        {
            String num = ("098 87 89 89");
            Account myAccount = new Account(num);
            String expected = "19:15";
            String output = myAccount.validateStartTime(expected);




        }
    }


}
