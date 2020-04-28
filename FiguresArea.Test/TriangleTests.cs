using System;
using Xunit;
using FiguresArea.Figures;
using FiguresArea.Exeptions;

namespace FiguresArea.Test
{
    /// <summary>
    /// Тест пользовательских прямоугольников
    /// </summary>
    public class TriangleTests
    {
        //Ввод правильного многоугольника
        [Fact]
        public void CorrectеTriangle()
        {
            Triangle triangle = new Triangle(4,6,4);
            double p = (4 + 6 + 4) / 2.0;
            Assert.Equal(Math.Sqrt(p*(p-4)*(p-6)*(p-4)),triangle.Area());
            Assert.False(triangle.IsRight());

        }

        //Ввод прямоугольного многоугольника
        [Fact]
        public void RightTriangle()
        {
            Triangle triangle = new Triangle(4, 5, 3);
            double p = (4 + 5 + 3) / 2.0;
            Assert.Equal(Math.Sqrt(p * (p - 4) * (p - 5) * (p - 3)), triangle.Area());
            Assert.True(triangle.IsRight());
        }

        //Ввод неправильного многоугольника
        [Theory]
        [InlineData(4,6,0)]
        [InlineData(4,6,-7)]
        public void ZeroOrNegativeSideTriangle(double a, double b,double c)
        {
            Triangle triangle;
            var exeption = Assert.Throws<InvalidFigureParameters>(() => triangle = new Triangle(a, b, c));
            Assert.Equal("Стороны треугольника должны быть больше нуля.", exeption.Message);

        }

        //Ввод неправильного многоугольника
        [Fact]
        public void IncorrectTriangle()
        {
            Triangle triangle;
            var exeption = Assert.Throws<InvalidFigureParameters>(() => triangle = new Triangle(11, 5, 6));
            Assert.Equal("Длина одной стороны не может быть больше, чем сумма длин других.", exeption.Message);

        }



    }
}
