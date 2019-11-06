using Contracts;

namespace ParkingBusinessLogic.Exceptions
{
    public class InvalidAccountUruguayException : LogicException
    {

        private static readonly string message = "The account has two rules, the number should have the format 098 89 84 23 or 98234584, with or without spaces, and the balance must be positive number.";

        public InvalidAccountUruguayException() : base(message)
        {

        }
    }
}
