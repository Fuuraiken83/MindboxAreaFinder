using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  FiguresArea.Exeptions;
using  FiguresArea.Interfaces;

namespace FiguresArea.Figures
{
    /// <summary>
    /// Построение треугольника
    /// </summary>
    public class Triangle : IFigure, IFigureBySides
    {
        public double[] sides { get; private set; }
            

        public Triangle(double a, double b, double c)
        {
            this.sides = new double[] { a, b, c };
            if (a <= 0 || b<=0 || c<= 0)
            {
                throw new InvalidFigureParameters("Стороны треугольника должны быть больше нуля.");
            }
            if ((sides.Max() * 2) >= sides.Sum())
            {
                throw new InvalidFigureParameters("Длина одной стороны не может быть больше, чем сумма длин других.");
            }
        }

        /// <summary>
        /// Рассчет площади треугольника
        /// </summary>
        public double Area()
        {
            double area = 0;
            double sp = (sides[0] + sides[1] + sides[2])/2;
            area = Math.Sqrt(sp * (sp - sides[0]) * (sp - sides[1]) * (sp - sides[2]));
            if (area <= .0)
            {
                throw new InvalidFigureParameters("Площадь треугольника не может быть меньше нуля.");
            }
            return area;
        }

        /// <summary>
        /// Проверка, является ли треугольник прямоугольным
        /// </summary>
        public bool IsRight()
        {
            return Math.Pow(sides.Max(), 2) * 2 == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2);
        }

    }
}
