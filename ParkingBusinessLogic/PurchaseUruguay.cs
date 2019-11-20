using Contracts;
using ParkingBusinessLogic.Exceptions;
using System;

namespace ParkingBusinessLogic
{
    public class PurchaseUruguay : Purchase
    {
       
        public PurchaseUruguay()
        {
        }
        public PurchaseUruguay( string msg, Account myA) : base(msg, myA, new MinuteParserUruguay())
        {

        }
       


    }
}
