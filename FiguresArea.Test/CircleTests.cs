using System;
using Xunit;
using FiguresArea.Figures;
using FiguresArea.Exeptions;

namespace FiguresArea.Test
{
    /// <summary>
    /// Тесты кругов
    /// </summary>
    public class CircleTests
    {
        //Правильный круг
        [Fact]
        public void CorrectCircle()
        {
            double radius = 10.0;
            Circle circle = new Circle(radius);
            double circleArea = circle.Area();
            Assert.Equal(Math.PI * Math.Pow(radius, 2), circleArea);

        }

        //Неравильный круг
        [Theory]
        [InlineData(-1.0)]
        [InlineData(.0)]
        public void IncorrectCircle(double radius)
        {
            Circle circle;
            var exeption = Assert.Throws<InvalidFigureParameters>(() => circle = new Circle(radius));
            Assert.Equal("Радиус должен быть больше 0.", exeption.Message);

        }
    }
}
