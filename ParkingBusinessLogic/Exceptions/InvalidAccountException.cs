using Contracts;

namespace ParkingBusinessLogic.Exceptions
{
    public class InvalidAccountException : LogicException
    {

        private static readonly string message = "The number is invalid or the balance is incorrect";

        public InvalidAccountException() : base(message)
        {

        }
    }
}
