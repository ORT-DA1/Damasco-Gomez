using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Diagnostics.CodeAnalysis;
using EFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;
using ParkingBusinessLogic.Exceptions;

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
            myDA.DeleteDataBase();
        }

        [TestMethod]
        public void TestInsertAccountUru()
        {
            myDA.Insert(myAccountUru);
        }
        [Ignore]
        [TestMethod]
        [ExpectedException(typeof(DbException))]
        public void TestInsertAccountUruFailConnection()
        {
            myDA.Insert(myAccountUru);
        }
        [TestMethod]
        [ExpectedException(typeof(DbUpdateException))]
        public void TestInsertAccountUruFailEqual()
        {
            myDA.Insert(myAccountUru);
            myDA.Insert(myAccountUru);
        }
        [TestMethod]
        public void TestInsertAccountArg()
        {
            myDA.Insert(myAccountArg);
        }
        [Ignore]
        [TestMethod]
        [ExpectedException(typeof(DbException))]
        public void TestInsertAccountArgFailConnection()
        {
            myDA.Insert(myAccountArg);
        }
        [TestMethod]
        [ExpectedException(typeof(DbUpdateException))]
        public void TestInsertAccountArgFailEqual()
        {
            myDA.Insert(myAccountArg);
            myDA.Insert(myAccountArg);
        }

        [TestCleanup]
        public void FinishTest()
        {
            myDA.DisposeMyContext();
        }


    }
}
