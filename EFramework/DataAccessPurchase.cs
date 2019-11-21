﻿using ContractDataBase;
using ParkingBusinessLogic;
using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFramework
{
    public class DataAccessPurchase : IDataAccess<Purchase>
    {
        const string problemConnection = "the data base is not connected";
        const string samePurchase = "you have a purchase in that init hour";

        public MyContext Context { get;  set; }

        public DataAccessPurchase(MyContext context)
        {
            Context = context;
        }
        public void DisposeMyContext()
        {
            Context.Dispose();
        }

        public void Insert(Purchase purchase)
        {
            try
            {

                Context.Purchases.Add(purchase);
                Context.SaveChanges();
            }
            catch (DbException e)
            {
                throw new DataBaseException(samePurchase); 
            }
            catch (UpdateException e)
            {
                throw new DataBaseException(problemConnection); 
            }
            catch (DbUpdateException e)
            {
                throw new DataBaseException(samePurchase);
            }
        }
        public void DeleteDataBase()
        {
            Context.Database.ExecuteSqlCommand("delete from Purchases;");
            Context.Database.ExecuteSqlCommand("delete from Accounts;");

        }

        public List<Purchase> AllData()
        {
            var listPurchase = Context.Purchases;
            List<Purchase> myPurchases = new List<Purchase>();
            foreach (var a in listPurchase)
            {
                myPurchases.Add(a);
            }
            return myPurchases;
        }

    
        public void Update()
        {
            Context.SaveChanges();
        }

    }
}
