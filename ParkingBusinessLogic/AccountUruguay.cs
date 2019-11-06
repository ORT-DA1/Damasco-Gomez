using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParkingBusinessLogic
{
    public class AccountUruguay : Account
    {
        public AccountUruguay()
        {
            setNumber("");
            setBalance(0);
        }

        public AccountUruguay(String num, string balance)
        {
            if (ValidateFormatNum(num) && ValidateBalance(balance)) {
                setNumber(FormatNum(num));
                setBalance(FormatBalance(balance));
            }
            else
            {
                throw new InvalidAccountUruguayException();
            }

        }

        public override string FormatNum(string num)
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
                throw new InvalidAccountUruguayException();
            }
            return num;
        }

        public override bool ValidateFormatNum(string num)
        {
            num = num.Replace(" ", "");
            return Regex.IsMatch(num, @"^0?[9][^3]\d{6}");
        }

    }
}
