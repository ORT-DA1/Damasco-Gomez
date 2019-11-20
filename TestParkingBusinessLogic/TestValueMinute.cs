using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;
using ParkingBusinessLogic.Exceptions;
using System.Diagnostics.CodeAnalysis;

namespace TestParkingBusinessLogic
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class TestValueMinute
    {
        ValueMinute myValue;

        [TestInitialize]
        public void InitTest()
        {
            myValue = new ValueMinute();
        }
        [TestMethod]
        public void TestTotalPricePositivo()
        {
            int cantMinutes = 120;
            int totalPrice = myValue.TotalPrice(cantMinutes);
            int expected = 3 * 120;
            Assert.AreEqual(totalPrice, expected);
        }
        [TestMethod]
        [ExpectedException(typeof(NegativeNumberException))]
        public void TestTotalPriceNegativo()
        {
            int cantMinutes = -120;
            int totalPrice = myValue.TotalPrice(cantMinutes);
        }

        [TestMethod]
        public void TestChangeValue()
        {
            int NewValue = 400;
            myValue.ChangeValue(NewValue.ToString());
            int Output = myValue.ValuePerMinutes;
            Assert.AreEqual(NewValue, Output);
        }

    }
}
