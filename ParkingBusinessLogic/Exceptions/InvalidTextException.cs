using Contracts;

namespace ParkingBusinessLogic.Exceptions
{
    public class InvalidTextException : LogicException
    {

        private static readonly string message = "Message is incorrect. The format should be: ABC 1234 60 10:00";

        public InvalidTextException() : base(message)
        {

        }
    }
}
