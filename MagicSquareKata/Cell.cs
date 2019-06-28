namespace MagicSquareKata
{
    using System.Collections.Generic;
    using MagicSquareKata.Exceptions;

    public class Cell : ValueObject
    {
        private readonly int value;

        private Cell(int value)
        {
            if (value < 1)
            {
                throw new InvalidTupleValueException();
            }
            
            this.value = value;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return this.value;
        }

        public static implicit operator int(Cell cell) => cell.value;

        public static implicit operator Cell(int value) => new Cell(value);
    }
}