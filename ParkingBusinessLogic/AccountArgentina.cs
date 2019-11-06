using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParkingBusinessLogic
{
    public class AccountArgentina : Account
    {
        public AccountArgentina()
        {
            setNumber("");
            setBalance(0);
        }

        public AccountArgentina(String num, string balance)
        {
            if (ValidateFormatNum(num) && ValidateBalance(balance))
            {
                setNumber(FormatNum(num));
                setBalance(FormatBalance(balance));
            }
            else
            {
                throw new InvalidAccountArgentinaException();
            }

        }

        public override string FormatNum(string num)
        {
            num = num.Replace("-", "").Trim();            
            return num;
        }

        public override bool ValidateFormatNum(string num)
        {
            num = num.Replace("-", "").Trim();
            return Regex.IsMatch(num, @"^\d{6,8}$");
        }
    }
}
