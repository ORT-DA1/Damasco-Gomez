using EFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParkingBusinessLogic;
using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEntityFramework
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class TestDataFindAccount
    {
        DataAccessAccount myDAInsert;
        DataFindAccount myDAFind;
        AccountUruguay myAccountUru;
        AccountArgentina myAccountArg;

        [TestInitialize]
        public void InitTest()
        {
            MyContext myContext = new MyContext();
            myDAInsert = new DataAccessAccount(myContext);
            myDAFind = new DataFindAccount(myContext);
            myAccountUru = new AccountUruguay("094485968", "100");

            myAccountArg = new AccountArgentina("123-456-78", "100");
            myDAInsert.DeleteDataBase();
        }

        [TestMethod]
        public void TestFindAcccountUruByNum()
        {
            myDAInsert.Insert(myAccountUru);
            Account accountUruguay = myDAFind.FindAccountByNumber("094 485 968");
            Assert.AreEqual(myAccountUru.Number, accountUruguay.Number);
        }
        [TestMethod]
        [ExpectedException(typeof(NotAccountException))]
        public void TestFindAcccountUruByNumFail()
        {
            Account accountUruguay = myDAFind.FindAccountByNumber("094 485 968");
        }
        [TestMethod]
        public void TestFindAcccountArgByNum()
        {
            myDAInsert.Insert(myAccountArg);
            Account accountArgentina = myDAFind.FindAccountByNumber("12345678");
            Assert.AreEqual(myAccountArg.Number, accountArgentina.Number);
        }
        [TestMethod]
        [ExpectedException(typeof(NotAccountException))]
        public void TestFindAcccountArgByNumFail()
        {
            Account accountArgentina = myDAFind.FindAccountByNumber("12345678");
        }
        [TestCleanup]
        public void FinishTest()
        {
            myDAFind.DisposeMyContext();
        }
    }
}
