
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
            get {
                return number;
            }
            private set {
                if(ValidateFormat(value))
                {
                    number = Format(value);
                }
                throw new InvalidNumberException();
            }
        }

        private string Format(string num)
        {
            num = num.Replace(" ", "");
            if (num.Length==9)
            {
                num = num.Insert(6, " ");
                num = num.Insert(3, " ");
            } else if (num.Length==8)
            {
                num = num.Insert(5, " ");
                num = num.Insert(2, " ");
            } else
            {
                throw new InvalidNumberException();
            }
            return num;
        }

        public Account(string num)
        {
            Number = num;
        }

        public Boolean AddBalance()
        {
            return true;
        }

        public Boolean  ValidateFormat(String num)
        {
            Boolean result = false;
            num = num.Replace(" ","");
            Regex expretion = new Regex(@"0?[9][^3]\d{6}$");

            if (expretion.IsMatch(num)) { 
               result = true;
                    
            }
            return result;
        }

        public Boolean  EnoughBalance ()
        {
            return true;
        } 

    }
}
