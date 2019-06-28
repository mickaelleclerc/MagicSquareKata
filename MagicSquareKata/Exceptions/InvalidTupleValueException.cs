namespace MagicSquareKata.Exceptions
{
    using System;

    public class InvalidTupleValueException : Exception
    {
        public InvalidTupleValueException()
            : base("Tuple value must be strictly positive")
        {
        }
    }
}