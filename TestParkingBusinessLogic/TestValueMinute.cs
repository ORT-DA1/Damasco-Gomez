using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;
using ParkingBusinessLogic.Exceptions;
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
    public class TestValueMinute
    {
        [TestMethod]
        public void TestTotalPricePositivo()
        {
            ValueMinute myValue = new ValueMinute();
            int cantMinutes = 120;
            int totalPrice = myValue.TotalPrice(cantMinutes);
            int expected = 30 * 120;
            Assert.AreEqual(totalPrice, expected);
        }
        [TestMethod]
        [ExpectedException(typeof(NegativeNumberException))]
        public void TestTotalPriceNegativo()
        {
            ValueMinute myValue = new ValueMinute();
            int cantMinutes = -120;
            int totalPrice = myValue.TotalPrice(cantMinutes);
         
            
        }

    }
}
