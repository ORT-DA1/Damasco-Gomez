using ParkingBusinessLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParkingBusinessLogic
{
    class LicensePlateParser
    {
        private String licensePlate;
        public String LicensePlate
        {
            get
            {
                return licensePlate;
            }
            private set
            {
                licensePlate = value;
            }
        }
        public LicensePlateParser()
        {

        }
        public LicensePlateParser(String License)
        {
            LicensePlate = License;
        }

        private string ValidateLicensePlate(string licensePlate)
        {
            if (!licensePlate.Equals("") && Regex.IsMatch(licensePlate, @"^[a-zA-Z]{3}\d{4}$"))
            {
                return licensePlate;
            }
            else
            {
                throw new InvalidTextException();
            }
        }

        public string ParseLicensePlate(string msg)
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

        public String GetLicensePlate(String txt)
        {
            String License = ParseLicensePlate(txt);
            License = ValidateLicensePlate(License);
            return License;
        }
    }
}
