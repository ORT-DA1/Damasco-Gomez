using EFramework;
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
    public class TestControllerPurchase
    {
        private ControllerPurchase myController;

        [TestInitialize]
        public void Init()
        {
            MyContext myContext = new EFramework.MyContext();
            DataAccessAccount accessAccount = new DataAccessAccount(myContext);
            DataFindAccount findAccount = new DataFindAccount(myContext);
            DataAccessPurchase accessPurchase = new DataAccessPurchase(myContext);
            DataFindPurchase findPurchase = new DataFindPurchase(myContext);
            myController = new ControllerPurchase(accessPurchase, accessAccount, findAccount, findPurchase);
            myController.dataAccessAccount.DeleteDataBase();
        }
    }
}
