namespace MagicSquareKata
{
    using System.Collections.Generic;

    public class MagicConstant : ValueObject
    {
        private readonly int value;
        
        public MagicConstant(Order order)
        {
            this.value = (1 + order * order) * order / 2;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return this.value;
        }

        public static implicit operator int(MagicConstant magicConstant) => magicConstant.value;
    }
}