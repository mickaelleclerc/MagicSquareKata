namespace MagicSquareKata.Tests
{
    using FluentAssertions;
    using Xunit;
    
    public class MagicConstantTests
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(3, 15)]
        [InlineData(4, 34)]
        public void Given_Order_Then_ShouldComputeMagicConstant(int order, int expectedMagicConstant)
        {
            // Act
            var magicConstant = new MagicConstant(new Order(order));
            
            // Assert
            var magicConstantAsInt = (int) magicConstant;
            magicConstantAsInt.Should().Be(expectedMagicConstant);
        }
    }
}