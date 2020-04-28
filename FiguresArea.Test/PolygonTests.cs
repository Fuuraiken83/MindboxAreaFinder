using System;
using Xunit;
using FiguresArea.Figures;
using FiguresArea.Exeptions;
using FiguresArea.Primitives;

namespace FiguresArea.Test
{
    /// <summary>
    /// Тест пользовательских прямоугольников
    /// </summary>
    public class PolygonTests
    {
        //Ввод правильного многоугольника
        [Fact]
        public void CorrectPolygon()
        {
            Point[] points = { new Point(0, 0), new Point(100, 0), new Point(100, 100), new Point(0, 100) };
            Polygon polygon = new Polygon(points);
            Assert.Equal(10000, polygon.Area());

        }

        //Ввод двух точек
        [Fact]
        public void TwoPointPolygon()
        {
            Point[] points = { new Point(0, 0), new Point(100, 0)};
            Polygon polygon;
            var exeption = Assert.Throws<InvalidFigureParameters>(() => polygon = new Polygon(points));
            Assert.Equal("Для многоугольника нужно минимум 3 точки.", exeption.Message);

        }

        //Ввод 2 повторяющихся точек в наборе
        [Fact]
        public void SamePointPolygon()
        {
            Point[] points = { new Point(0, 0), new Point(100, 0), new Point(100, 100), new Point(0, 0) };
            Polygon polygon;
            var exeption = Assert.Throws<InvalidFigureParameters>(() => polygon = new Polygon(points));
            Assert.Equal("В Вашем наборе не должно быть повторяющихся точек.", exeption.Message);

        }

        //Ввод точек в другом порядке
        [Fact]
        public void IncorrectPolygon()
        {
            Point[] points = { new Point(0, 0), new Point(100, 0), new Point(0, 100), new Point(100, 100) };
            Polygon polygon;
            var exeption = Assert.Throws<InvalidFigureParameters>(() => polygon = new Polygon(points));
            Assert.Equal("Площадь фигуры должна быть положительной.", exeption.Message);

        }

        //Ввод 3 коллиниарных точек
        [Fact]
        public void CollinearPolygon()
        {
            Point[] points = { new Point(0, 0), new Point(100, 0), new Point(200, 0),};
            Polygon polygon;
            var exeption = Assert.Throws<InvalidFigureParameters>(() => polygon = new Polygon(points));
            Assert.Equal("Площадь фигуры должна быть положительной.", exeption.Message);

        }

    }
}