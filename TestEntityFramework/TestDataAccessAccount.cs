using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using EFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;

namespace TestEntityFramework
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class TestDataAccessAccount
    {
        DataAccessAccount myDA;
        AccountUruguay myAccountUru;
        AccountArgentina myAccountArg;

        [TestInitialize]
        public void InitTest()
        {
            myDA = new DataAccessAccount(new MyContext());

            myAccountUru = new AccountUruguay("094485968", "100");

            myAccountArg = new AccountArgentina("123-456-78", "100");

            myDA.Context.Database.ExecuteSqlCommand("delete from Purchases;");
            myDA.Context.Database.ExecuteSqlCommand("delete from Accounts;");

        }

        [TestMethod]
        public void InsertAccountUru()
        {
            myDA.Insert(myAccountUru);
        }
        [TestMethod]
        public void InsertAccountArg()
        {
            myDA.Insert(myAccountArg);
        }


        [TestCleanup]
        public void FinishTest()
        {
            myDA.DisposeMyContext();
        }


    }
}
