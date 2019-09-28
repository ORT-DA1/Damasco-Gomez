using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParkingBusinessLogic
{
    [TestClass]
    class TestPurchase
    {

        [TestMethod]
        public void TestCreatePurchase()
        {
            Account myAccount = new Account("098872898");
            string text = "SBN 2208 150 10:00";
            Purchase myPurchase = new Purchase(text, myAccount);

        }

        [TestMethod]
        public void TestCheckLicensePlate()
        {
            Account myAccount = new Account("098872898");
            string text = "SBN 2208 150 10:00";
            Purchase myPurchase = new Purchase(text, myAccount);
            string expected = "SBN2208";
            string output = myPurchase.MyLicensePlate;
            Assert.AreEqual(output, expected);

        }





    }
}
