using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  FiguresArea.Exeptions;
using  FiguresArea.Interfaces;
using  FiguresArea.Primitives;

namespace  FiguresArea.Figures
{
    /// <summary>
    /// Построение произвольного многоугольника
    /// </summary>
    public class Polygon : IFigure, IFigureByPoints
    {
        public Point[] points { get; private set; }

        public Polygon(Point[] points)
        {
            if (points.Length != points.GroupBy(p => new {p.x, p.y}).Distinct().Count())
            {
                throw new InvalidFigureParameters("В Вашем наборе не должно быть повторяющихся точек.");
            }
            if (points.Length < 3)
            {
                throw new InvalidFigureParameters("Для многоугольника нужно минимум 3 точки.");
            }
            this.points = points;
            Area();
        }

        /// <summary>
        /// Рассчет площади произвольного многоугольника
        /// </summary>
        public double Area()
        {
            double area = .0;

            for (int i = 0; i < points.Length; i++)
            {
                area += (points[i].x * points[(i + 1) % points.Length].y) - (points[i].y * points[(i + 1) % points.Length].x);
            }

            if (area == .0)
            {
                throw new InvalidFigureParameters("Площадь фигуры должна быть положительной.");
            }

            area = 0.5 * Math.Abs(area);
            return area;
        }
    }

    
}
