using ParkingBusinessLogic.Exceptions;
using System;
using System.Text.RegularExpressions;

namespace ParkingBusinessLogic
{
    public class LicensePlateParser
    {


        public LicensePlateParser()
        {

        }

        public bool ValidateLicensePlate(string licensePlate)
        {
            if (!licensePlate.Equals("") && Regex.IsMatch(licensePlate, @"^[a-zA-Z]{3}\d{4}$"))
            {
                return true;
            }
            else
            {
                return false;
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

        public string GetLicensePlate(string txt)
        {
            String License = ParseLicensePlate(txt);
            if (ValidateLicensePlate(License))
            {
                return License;
            }
            else
            {
                throw new InvalidTextExceptionArgentina();
            }
        }

        public string FormatAndValidateLicensePlate(string licensePlate)
        {
            licensePlate = licensePlate.Replace(" ", "");
            if (ValidateLicensePlate(licensePlate))
            {
                return licensePlate;
            }
            else
            {
                throw new InvalidTextExceptionArgentina();
            }

        }
    }

}
