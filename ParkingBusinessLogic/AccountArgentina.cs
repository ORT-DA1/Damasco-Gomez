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
            Number = "";
            Balance = 0;
        }

        public AccountArgentina(String num, string balance)
        {
            if (ValidateFormatNum(num) && ValidateBalance(balance))
            {
                Number = FormatNum(num);
                Balance = FormatBalance(balance);
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
            num = num.Trim();
            return Regex.IsMatch(num, @"^\d(\d|-\d){5}(\d|-\d)?(\d|-\d)?$");
         
        }
    }
}
