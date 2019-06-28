namespace MagicSquareKata.Exceptions
{
    using System;

    public class InvalidOrderException : Exception
    {
        public InvalidOrderException()
            : base("Order must be strictly positive")
        {
        }
    }
}