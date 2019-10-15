using Contracts;

namespace ParkingBusinessLogic.Exceptions
{
    public class NegativeNumberException : LogicException
    {
        private static readonly string message = "The input number should be positive";

        public NegativeNumberException() : base(message)
        {

        }
    }
}
