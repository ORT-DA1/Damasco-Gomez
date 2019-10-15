using Contracts;

namespace ParkingBusinessLogic.Exceptions
{
    public class InsufficientBalanceException : LogicException
    {
        private static readonly string message = "The balance in the account is not enough to do the purchase.";

        public InsufficientBalanceException() : base(message)
        {

        }

    }
}
