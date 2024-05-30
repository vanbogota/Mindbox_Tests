using AreaCalculators.Implementation;

namespace AreaCalculatorsTests
{
    public class CircleFigureUnitTests
    {
        Circle circle = new(5.5);

        [Fact]
        public void Radius_InputIs5_Returns_DoubleType()
        {
            Assert.IsType<double>(circle.Radius);
            Assert.Equal(5.5, circle.Radius);
        }
        [Fact]
        public void CalculateArea_InputRadiusIs5_Returns_DoubleType()
        {
            Assert.IsType<double>(circle.CalculateArea());
        }

        [Fact]
        public void Radius_InputIsBelowZero_Throws_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => { new Circle(-1); });
            Exception ex = Assert.Throws<ArgumentOutOfRangeException>(() => { new Circle(0); });
            Assert.Contains("Radius must be over 0.", ex.Message);
        }

        [Fact]
        public void CalculateArea_InputRadiusIs1_Returns_RightValue()
        {
            Circle circleWithRadius1 = new(1);
            Assert.Equal(Math.PI, circleWithRadius1.CalculateArea());
        }

    }
}