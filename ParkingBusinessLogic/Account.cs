
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
        private int amount;
        public int Amount
        {
            get
            {
                return amount;
            }
            private set
            {
                amount = value;
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

        public bool AddBalance()
        {
            return true;
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
        public void AskforParking(string num, string msg)
        {
            if (validateMsg(msg))
            {

            }
            else
            {
                throw new InvalidTextException();
            }
        }


    }
}



    