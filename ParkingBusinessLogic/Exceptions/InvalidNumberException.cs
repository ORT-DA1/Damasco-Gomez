using Contracts;

namespace ParkingBusinessLogic.Exceptions
{
    public class InvalidNumberException : LogicException
    {

        private static readonly string message = "The number is invalid";

        public InvalidNumberException() : base(message)
        {

        }
    }
}
