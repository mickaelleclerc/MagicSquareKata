namespace MagicSquareKata.Tests
{
    using System.Collections.Generic;
    using FluentAssertions;
    using Xunit;

    public class TupleTests
    {
        [Fact]
        public void Given_Tuple_When_SumIsEqualToMagicConstant_Then_TupleIsValid()
        {
            // Arrange
            var magicConstant = new MagicConstant(new Order(4));
            var tuple = new Tuple(new List<Cell> { 1, 15, 14, 4 });
            
            // Act
            bool isValid = tuple.IsMagic(magicConstant);
            
            // Assert
            isValid.Should().BeTrue();
        }
        
        [Fact]
        public void Given_Tuple_WhenSumIsNotEqualToMagicConstant_Then_TupleIsInvalid()
        {
            // Arrange
            var magicConstant = new MagicConstant(new Order(4));
            var tuple = new Tuple(new List<Cell> { 1, 15, 14, 3456 });
            
            // Act
            bool isValid = tuple.IsMagic(magicConstant);
            
            // Assert
            isValid.Should().BeFalse();
        }
    }
}