using Contracts;

namespace ParkingBusinessLogic.Exceptions
{
    public class NotAccountException : LogicException
    {
        private static readonly string message = "The account with that number does not exist";
        public NotAccountException() : base(message)
        {

        }
    }

}

