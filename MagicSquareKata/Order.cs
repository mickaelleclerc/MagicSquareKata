namespace MagicSquareKata
{
    using System.Collections.Generic;
    using MagicSquareKata.Exceptions;

    /// <summary>
    /// A square grid with n cells on each side is said to have order n
    /// </summary>
    public class Order : ValueObject
    {
        private readonly int value;

        public Order(int value)
        {
            if (value < 1)
            {
                throw new InvalidOrderException();
            }
            
            this.value = value;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return this.value;
        }

        public static implicit operator int(Order order) => order.value;
        
        public static explicit operator Order(int value) => new Order(value);
    }
}