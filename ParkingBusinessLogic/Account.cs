<<<<<<< HEAD
﻿using System;
=======
using System;
>>>>>>> a3da371c5930b235f97ae2f22009c6378d496ff4
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBusinessLogic
{
    public class Account
    {
<<<<<<< HEAD
        public Boolean addBalance()
        {
            return true;
        }

        public String validateFormat(String num)
        {
            String result = "Formato Invalido";
            num = num.Replace(" ","");

            if ((num.Length == 9) || (num.Length == 8))
            {
                if (num.All(char.IsDigit))
                {
                    if((num.Length == 9) && (num[0] == '0') && (num[1]=='9') && (num[2]!='3'))
                    {
                        result = num.Insert(6," ") ;
                        result = result.Insert(3, " ");
                    } else if ((num[0]=='9') && (num[1]!='3') && (num.Length == 8))
                    {
                        result = num.Insert(5, " ");
                        result = result.Insert(2, " ");
                    }
                }
            }
            return result;
        }

        public Boolean  enoughBalance ()
        {
            return true;
        } 

    }
}
=======


        public Boolean addBalance()
        {
            return true;
        }
    }
}
>>>>>>> a3da371c5930b235f97ae2f22009c6378d496ff4
