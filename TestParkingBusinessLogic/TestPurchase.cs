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
        public void createPurchase()
        {
            Account myAccount = new Account("098872898");
            string licensePlate = "";
            string day = DateTime.Now.Day + "/" +DateTime.Now.Month;
            string initHour = "10:00";
            string finHour = "11:00";
            Purchase myPurchase = new Purchase(myAccount, licensePlate, day,initHour,finHour);

        }


    }
}
