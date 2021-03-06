
using ParkingBusinessLogic.Exceptions;
using System;
using System.Text.RegularExpressions;



namespace ParkingBusinessLogic
{
    public class Account
    {

        private string number;
        public string Number
        {
            get
            {
                return number;
            }
            private set
            {
                if (ValidateFormat(value))
                {
                    number = Format(value);
                }
                else
                {
                    throw new InvalidNumberException();
                }
            }
        }
        private int balance;
        public int Balance
        {
            get
            {
                return balance;
            }
            private set
            {
                balance = value;
            }



        }
        public Account(String num, int balance)
        {
            Number = num;
            Balance = balance;

        }

        public string Format(string num)
        {
            num = num.Replace(" ", "");
            if (num.Length == 9)
            {
                num = num.Insert(6, " ");
                num = num.Insert(3, " ");
            }
            else if (num.Length == 8)
            {
                num = num.Insert(5, " ");
                num = num.Insert(2, " ");
            }
            else
            {
                throw new InvalidNumberException();
            }
            return num;
        }

        public Account()
        {
            this.number = "";
            Balance = 0;
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


        public bool ValidateFormat(string num)
        {
            num = num.Replace(" ", "");
            return Regex.IsMatch(num, @"^0?[9][^3]\d{6}");
        }

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



