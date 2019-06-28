namespace MagicSquareKata.Tests
{
    using System;
    using FluentAssertions;
    using MagicSquareKata.Exceptions;
    using Xunit;

    public class CellTests
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void Given_NonStrictlyPositiveCell_Then_ShouldThrowInvalidTupleValueException(int cell)
        {
            // Act
            Func<Cell> func = () => cell;
            
            // Assert
            func.Should().Throw<InvalidTupleValueException>();
        }
        
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        public void Given_StrictlyPositiveCell_Then_ShouldCreateTupleValue(int value)
        {
            // Act
            Func<Cell> func = () => value;
            
            // Assert
            func.Should().NotThrow<InvalidTupleValueException>();
        }
    }
}