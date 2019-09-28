
using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



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

        private string Format(string num)
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

        public Account(string num)
        {
            Number = num;
        }

        public bool AddBalance(Account account, int cant)
        { 

            if (cant>0)
            {
                int previosBalance = account.balance;
                account.balance = previosBalance + cant;
                return true;
            } else
            {
                throw new NegativeNumberException();
            }
            
         }
        

        public bool ValidateFormat(string num)
        {
            num = num.Replace(" ", "");
            return Regex.IsMatch(num, @"^0?[9][^3]\d{6}");
        }

        public bool EnoughBalance()
        {
            return true;
        }
        public bool DiscountBalance(int amount)
        {
            return true;
        }



    }
}



    