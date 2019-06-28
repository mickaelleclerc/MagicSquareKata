namespace MagicSquareKata.Tests
{
    using System;
    using FluentAssertions;
    using MagicSquareKata.Exceptions;
    using Xunit;

    public class OrderTests
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void Given_NonStrictlyPositiveValue_Then_ShouldThrowInvalidOrderException(int value)
        {
            // Act
            Func<Order> func = () => new Order(value);
            
            // Assert
            func.Should().Throw<InvalidOrderException>();
        }
        
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        public void Given_StrictlyPositiveValue_Then_ShouldCreateOrder(int value)
        {
            // Act
            Func<Order> func = () => new Order(value);
            
            // Assert
            func.Should().NotThrow<InvalidOrderException>();
        }
    }
}