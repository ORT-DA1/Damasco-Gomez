
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

        public bool validateMsg(string msg)
        {

            string[] msgList = msg.Split(' ');
            string licensePlate = breakDownLicensePlate(msg);
            string cantMinutes = BreakDownCantMinutes(msg);
            string startTime = breakDownStarTime(msg);
           
            

            if (validateLicensePlate(licensePlate) && validateMinutesMultiple30(cantMinutes))
            {
                startTime = validateStartTime(startTime);
                return true;
            }
            else
            {
                return false;
            }
        }





        public string validateStartTime(string startTime)
        {
            if (!startTime.Equals("") && startTime.Contains(':'))
            {


                string[] hourmin = startTime.Split(':');
                string hour = hourmin[0];
                string min = hourmin[1];
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

        private bool validateMinutesMultiple30(string minutes)
        {
            int min = Int32.Parse(minutes);
            if ((min % 30) == 0)
            {

                return true;

            }
            else
            {
                throw new InvalidTextException();
            }


        }

        private bool validateLicensePlate(string licensePlate)
        {

            if (!licensePlate.Equals("") && Regex.IsMatch(licensePlate, @"^[a-zA-Z]{3}\d{4}$"))
            {
                return true;

            }
            else
            {

                throw new InvalidTextException();
            }

        }


        public string breakDownLicensePlate(string msg)
        {
            
            string licensePlate= ParseLicensePlate(msg);
            validateLicensePlate(licensePlate);
            return licensePlate;


           
           
        }

        private string ParseLicensePlate(string msg)
        {

            string[] msgList = msg.Split(' ');
            string licensePlate = "";
            if (msgList.Length >= 2)
            {
                if (msgList[0].Length == 3)
                {
                    licensePlate = msgList[0] + msgList[1];


                }
                else
                {
                    licensePlate = msgList[0];


                }

            }
            return licensePlate;
        }

        public string BreakDownCantMinutes(string msg)
        {

            string cantMinutes = ParseCantMinutes(msg);
            validateMinutesMultiple30(cantMinutes);
            return cantMinutes;


           
        }

        private string ParseCantMinutes(string msg)
        {

            string[] msgList = msg.Split(' ');
            
            string minutes = "";
            

            if (msgList.Length >= 2)
            {
                if (msgList[0].Length == 3)
                {
                    
                    minutes = msgList[2];
                   

                }
                else
                {
          
                    minutes = msgList[1]; 

                }      
                                             
            }
            return minutes;

        }

        public string breakDownStarTime(string msg)
        {

            string starTime = ParseStarTime(msg);
            validateStartTime(starTime);
            return starTime;

          
        }
        public string ParseStarTime(string msg)
        {
            string starTime = "";
            string[] msgList = msg.Split(' ');
            if (msgList.Length >= 2)
            {
                if (msgList[0].Length == 3)
                {

                    if (msgList.Length > 3)
                    {
                        starTime = msgList[3];
                    }

                }
                else
                {
                    if (msgList.Length > 2)
                    {

                        starTime = msgList[2];
                    }

                }
            }
            return starTime;


        }
    }
}



    