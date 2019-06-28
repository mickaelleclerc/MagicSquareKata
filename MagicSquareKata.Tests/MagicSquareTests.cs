namespace MagicSquareKata.Tests
{
    using System.Collections.Generic;
    using FluentAssertions;
    using Xunit;
    
    public class MagicSquareTests
    {
        [Fact]
        public void Given_TrivialSquare_Then_SquareIsMagic()
        {
            // Arrange
            var tuples = new List<Tuple>
            {
                new Tuple(new List<Cell> { 1 } )
            };

            var order = new Order(1);
            
            // Act
            var magicSquare = new MagicSquare(new MagicConstant(order), tuples);
            
            // Assert
            magicSquare.IsMagic.Should().BeTrue();
        }

        [Fact]
        public void Given_TuplesWhereSumIsNotEqualToMagicConstant_Then_SquareIsMuggle()
        {
            // Arrange
            var tuples = new List<Tuple>
            {
                new Tuple(new List<Cell> {1, 15, 14, 4}),
                new Tuple(new List<Cell> {12, 6, 7, 9}),
                new Tuple(new List<Cell> {8, 15, 11, 5}),
                new Tuple(new List<Cell> {13, 3, 2, 16}),
                new Tuple(new List<Cell> {1, 12, 8, 13}),
                new Tuple(new List<Cell> {15, 62, 10, 3}),
                new Tuple(new List<Cell> {14, 7, 11, 2}),
                new Tuple(new List<Cell> {4, 9, 5, 16}),
                new Tuple(new List<Cell> {1, 6, 14, 16}),
                new Tuple(new List<Cell> {13, 3, 2, 16})
            };

            var order = new Order(4);

            // Act
            var magicSquare = new MagicSquare(new MagicConstant(order), tuples);

            // Assert
            magicSquare.IsMuggle.Should().BeTrue();
            magicSquare.IsMagic.Should().BeFalse();
        }

        [Fact]
        public void Given_TuplesWhereSumIsEqualToMagicConstant_Then_SquareIsMagic()
        {
            // Arrange
            var tuples = new List<Tuple>
            {
                new Tuple(new List<Cell> { 1, 15, 14, 4}),
                new Tuple(new List<Cell> { 12, 6, 7, 9}),
                new Tuple(new List<Cell> { 8, 10, 11, 5}),
                new Tuple(new List<Cell> { 13, 3, 2, 16}),
                new Tuple(new List<Cell> { 1, 12, 8, 13}),
                new Tuple(new List<Cell> { 15, 6, 10, 3}),
                new Tuple(new List<Cell> { 14, 7, 11, 2}),
                new Tuple(new List<Cell> { 4, 9, 5, 16}),
                new Tuple(new List<Cell> { 1, 6, 11, 16}),
                new Tuple(new List<Cell> { 13, 3, 2, 16})
            };
            
            var order = new Order(4);
            
            // Act
            var magicSquare = new MagicSquare(new MagicConstant(order), tuples);
            
            // Assert
            magicSquare.IsMagic.Should().BeTrue();
            magicSquare.IsMuggle.Should().BeFalse();
        }
    }
}