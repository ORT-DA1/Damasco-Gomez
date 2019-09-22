
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
                

                if (validateEnrollment(enrollment) && validateHoursMultiple30(cantHours))
                {
                    startTime = validateStartTime(startTime);
                    return true;
                }
                else { return false; }
            }
            else
            {
                return false;
            }
            
           


            
        }

        public String validateStartTime(string startTime)
        {
            if (!startTime.Equals("") && startTime.Contains(':')) {


                String[] hourmin = startTime.Split(':');
                String hour = hourmin[0];
                String min = hourmin[1];
                int hours = Int32.Parse(hour);
                int mins = Int32.Parse(min);
                if ((hours >= 10) && (hours <= 18))
                {
                    return startTime;

                }
                else { throw new InvalidTextException(); }


            }
            else
            {
                DateTime time = DateTime.Now;
                return time.ToString("h:mm");
                Console.WriteLine(time.ToString("h:mm"));
            }
        }

        private Boolean validateHoursMultiple30(string cantHours)
        {
            int hours = Int32.Parse(cantHours);
            if ((hours % 30) == 0) {

                return true;

            }
            else {
                throw new InvalidTextException();
            }
           
            
        }

        private Boolean validateEnrollment(string enrollment)
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
