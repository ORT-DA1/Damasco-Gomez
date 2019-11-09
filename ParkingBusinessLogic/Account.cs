
using ParkingBusinessLogic.Exceptions;
using System;
using System.Linq;
using System.Text.RegularExpressions;



namespace ParkingBusinessLogic
{
    public abstract class Account
    {

        private string number;
        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;                
            }
        }
        private int balance;
        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }


        public abstract string FormatNum(string num);

        public bool ValidateBalance(string balance)
        {
            return balance.All(char.IsDigit) && (Int32.Parse(balance)>0);
        }

        public int FormatBalance(string balance)
        {
            return Int32.Parse(balance);
        }
        
        





        public bool AddBalance(int cant)
        {

            if (cant > 0)
            {
                int previosBalance = Balance;
                Balance = previosBalance + cant;
                return true;
            }
            else
            {
                throw new NegativeNumberException();
            }

        }


        public abstract bool ValidateFormatNum(string num);


        public bool EnoughBalance(int value)
        {
            if (value <= Balance)
            {
                return true;
            }
            else
            {
                return false;

            }


        }
        public bool DiscountBalance(int amount)
        {
            if (amount > 0)
            {
                if (amount <= Balance)
                {
                    int actualBalance = Balance;
                    Balance = actualBalance - amount;
                    return true;
                }
                else
                {
                    throw new InsufficientBalanceException();
                }

            }
            else
            {

                throw new NegativeNumberException();
            }


        }
        public bool AccountEmpty()
        {

            if (Number == "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

 

    }
}



