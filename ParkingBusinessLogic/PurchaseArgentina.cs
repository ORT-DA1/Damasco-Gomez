using Contracts;
using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic
{
    public class PurchaseArgentina : Purchase
    {


        public PurchaseArgentina()
        {

        }
        public PurchaseArgentina(string msg, Account myA) : base(msg, myA, new MinuteParserArgentina())
        {
        }




    }
}
