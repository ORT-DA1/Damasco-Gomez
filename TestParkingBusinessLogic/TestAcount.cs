using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestParkingBusinessLogic
{
    [TestClass]
    public class TestAcount
    {
        [TestMethod]
        public void TestAddBalance()
        {
            Account myAccount = new Account();
            //Boolean expected = true;
            Boolean real = myAccount.addBalance();

            AssertTrue(real);

        }
    }
}