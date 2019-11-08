using Contracts;

namespace ParkingBusinessLogic.Exceptions
{
    public class InvalidTextExceptionUruguay : LogicException
    {

        private static readonly string message = "Message is incorrect. The format should be: ABC 1234 60 10:00";

        public InvalidTextExceptionUruguay() : base(message)
        {

        }
    }
}
