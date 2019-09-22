
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
        public int Amount {
            get {
                return amount;
                    }
            private set {
                amount = value;
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
            num = num.Replace(" ","");
            return Regex.IsMatch(num, @"^0?[9][^3]\d{6}" );
        }

        public Boolean  EnoughBalance ()
        {
            return true;
        } 
        public Boolean DiscountBalance(int amount) {
              return true;
        }
        public void AskforParking(String num, String msg)
        {
            if (validateMsg(msg))
            {

            } else
            {
                throw new InvalidTextException();
            }
        }

        public Boolean validateMsg(string msg)
        {

            String[] msgList = msg.Split(' ');
            String enrollment = "";
            String cantHours = "";
            String startTime = "";

            if (msgList.Length >= 2)
            {
                if (msgList[0].Length == 3)
                {
                    enrollment = msgList[0] + msgList[1];
                    cantHours = msgList[2];
                    if (msgList.Length > 3) {
                        startTime = msgList[3];
                    }
                       
                }
                else
                {
                    enrollment = msgList[0];
                    cantHours = msgList[1];
                    if (msgList.Length >2)
                    {

                        startTime = msgList[2]; 
                    }

                }
                Console.WriteLine(enrollment);
                Console.WriteLine(cantHours);
                Console.WriteLine(startTime);

                if (validarEnrollment(enrollment))
                {
                    return true;
                }
                else { return false; }
            }
            else
            {
                return false;
            }
            
           


            
        }

        private bool validarEnrollment(string enrollment)
        {
            
            if (!enrollment.Equals("") &&  Regex.IsMatch(enrollment, @"^[a-zA-Z]{3}\d{4}$"))
            {
                return true;
               
            }
            else {
                
                throw new InvalidTextException();
            }
            
        }
    }
}
