using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ParkingBusinessLogic
{
    public class ControllerAccount
    {
        public ControllerAccount()
        {

        }
        public bool RegisterAccount(Account account)
        {
            //Accounts.Add(account);
            return true;

        }
        public bool IsAccountEmpty(Account account)
        {
            //return account.AccountEmpty();
            return true;
        }

        /*
        public Account FindAccount(string text)
        {
            
            Account auxiliar = new AccountUruguay(text, "110");
            
            return auxiliar;
        }*/
        public void BuyParkingAccount(String num, String msg)
        {/*
            AccountUruguay myAccount = FindAccount(num);
            if (IsAccountEmpty(myAccount))
            {
                throw new NotAccountException();
            }
            else
            {
                ControllerPurchase controllerPurchase = new ControllerPurchase();
                int amountToDiscont = controllerPurchase.BuyParkingPurchaseUru(msg, myAccount);
                myAccount.DiscountBalance(amountToDiscont);
            }
            */
        }
    }
}
