using System;

namespace Contracts
{
    public class LogicException : Exception
    {
        public LogicException(string message) : base(message)
        {

        }
    }
}
