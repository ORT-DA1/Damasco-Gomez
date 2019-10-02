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
    public class TestController
    {
        [TestMethod]
        public void TestCreateAccout()
        {
            String num = "099 45 56 97";
            int balance = 190;
            Controller myC = new Controller();
            bool output = myC.RegisterAccount(num,balance);
            Assert.IsTrue(output);
        }

        [TestMethod]
        public void TestCreateAccout2()
        {
            String num = "099455697";
            int balance = 190;
            Controller myC = new Controller();
            bool output = myC.RegisterAccount(num, balance);
            Assert.IsTrue(output);
        }
    }
}
