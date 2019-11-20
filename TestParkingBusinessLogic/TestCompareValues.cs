using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestParkingBusinessLogic
{
    class TestCompareValues
    {
        private CompareValues compareValues;
        [TestInitialize]
        public void TestInit()
        {
            compareValues = new CompareValues();
        }
        [TestMethod]
        public void TestCompareHoursTrue()
        {
            string initHour = "16:40";
            string finitHour = "18:00";
            string otherHour = "17:00";
            bool output = compareValues.CompareHours(initHour, finitHour, otherHour);
            Assert.IsTrue(output);
        }
        [TestMethod]
        public void TestCompareHoursTrue2()
        {
            string initHour = "17:40";
            string finitHour = "18:00";
            string otherHour = "17:50";
            bool output = compareValues.CompareHours(initHour, finitHour, otherHour);
            Assert.IsTrue(output);
        }
        [TestMethod]
        public void TestCompareHoursTrue3()
        {
            string initHour = "12:40";
            string finitHour = "17:39";
            string otherHour = "17:30";
            bool output = compareValues.CompareHours(initHour, finitHour, otherHour);
            Assert.IsTrue(output);
        }
        [TestMethod]
        public void TestCompareHoursFalse()
        {
            string initHour = "14:10";
            string finitHour = "17:22";
            string otherHour = "11:00";
            bool output = compareValues.CompareHours(initHour, finitHour, otherHour);
            Assert.IsFalse(output);
        }
        [TestMethod]
        public void TestCompareHoursFalse1()
        {
            string initHour = "14:10";
            string finitHour = "15:22";
            string otherHour = "17:00";
            bool output = compareValues.CompareHours(initHour, finitHour, otherHour);
            Assert.IsFalse(output);
        }
        [TestMethod]
        public void TestCompareHoursFalse2()
        {
            string initHour = "11:30";
            string finitHour = "12:22";
            string otherHour = "11:00";
            bool output = compareValues.CompareHours(initHour, finitHour, otherHour);
            Assert.IsFalse(output);
        }
        [TestMethod]
        public void TestCompareHoursFals3()
        {
            string initHour = "10:50";
            string finitHour = "11:11";
            string otherHour = "11:40";
            bool output = compareValues.CompareHours(initHour, finitHour, otherHour);
            Assert.IsFalse(output);
        }
    }
}
