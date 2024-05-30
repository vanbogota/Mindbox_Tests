using AreaCalculators.Implementation;
using Xunit.Sdk;

namespace AreaCalculatorsTests
{
    public class TriangleFigureUnitTests
    {
        Triangle triangle = new(3, 4, 5);

        [Fact]
        public void Sides_InputIs3_4_5_Return_DoubleType()
        {
            Assert.IsType<double>(triangle.SideA);
            Assert.Equal(3, triangle.SideA);
            Assert.IsType<double>(triangle.SideB);
            Assert.Equal(4, triangle.SideB);
            Assert.IsType<double>(triangle.SideC);
            Assert.Equal(5, triangle.SideC);
        }

        [Fact]
        public void CheckIsRightTriangle_Returns_BooleanType()
        {
            Assert.IsType<bool>(triangle.CheckIsRightTriangle());
        }

        [Fact]
        public void Input3_4_5_CheckIsRightTriangle_Returns_True()
        {
            Assert.True(triangle.CheckIsRightTriangle());
        }

        [Fact]
        public void Input3_4_5_Returns_Right_Value()
        {
            Assert.Equal(6, triangle.CalculateArea());
            Assert.IsType<double>(triangle.CalculateArea());
        }

        [Fact]
        public void If_Side_Below_Zero_Throws_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 0, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, -1, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 0, -1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, -1, -1));
            Exception ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 1, 1));
            Assert.Contains("Three sides must be over 0.", ex.Message);
        }

        [Fact]
        public void If_Triangle_IsNot_Triangle_Throws_ArgumentException()
        {
            Exception ex = Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 125));
            Assert.Equal("The provided sides do not form a valid triangle.", ex.Message);
        }
    }
}
