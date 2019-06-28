using System.Collections.Generic;
using System.Linq;

namespace MagicSquareKata
{
    public class MagicSquare
    {
        private readonly MagicConstant magicConstant;
        private readonly IReadOnlyCollection<Tuple> tuples;

        public MagicSquare(MagicConstant magicConstant, IReadOnlyCollection<Tuple> tuples)
        {
            this.magicConstant = magicConstant;
            this.tuples = tuples;
        }

        public bool IsMagic => this.tuples.All(tuple => tuple.IsMagic(this.magicConstant));

        public bool IsMuggle => this.tuples.Any(tuple => !tuple.IsMagic(this.magicConstant));
    }
}