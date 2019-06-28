namespace MagicSquareKata
{
    using System.Collections.Generic;
    using System.Linq;
    
    /// <summary>
    /// A tuple represents a row, a column or a diagonal in a square.
    /// </summary>
    public class Tuple : ValueObject
    {
        private readonly IReadOnlyList<Cell> cells;

        public Tuple(IReadOnlyList<Cell> cells) => this.cells = cells;

        public bool IsMagic(MagicConstant magicConstant) => this.cells.Sum(cell => cell) == magicConstant;

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return this.cells;
        }
    }
}