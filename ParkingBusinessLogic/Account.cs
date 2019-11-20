
using ParkingBusinessLogic.Exceptions;
using System;
using System.Linq;
using System.Text.RegularExpressions;



namespace ParkingBusinessLogic
{
    public abstract class Account
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public int Balance { get; set; }

        public Account()
        {
            Id = new Guid();
            Balance = 0;
            Number = "";
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

        
        
        public bool AddBalance(string cant)
        {
            int newBalance = ValidateAndFormatBalance(cant);
            if (newBalance > 0)
            {
                int previosBalance = Balance;
                Balance = previosBalance + newBalance;
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
        
        public string ValidateAndFormat(string num, string formatNum)
        {
            if (ValidateFormatNum(num))
            {
                string number = FormatNum(num);
                return number;
            }
            else
            {
                throw new ExceptionNumberIncorrectFormat(formatNum);
            }
        }

        public int ValidateAndFormatBalance(string balance)
        {
            if (ValidateBalance(balance))
            {
                int newBalance = FormatBalance(balance);
                return newBalance;
            }
            else
            {
                throw new NegativeNumberException();
            }
        }
    }
}



