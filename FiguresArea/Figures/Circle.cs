using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiguresArea.Exeptions;
using FiguresArea.Interfaces;

namespace FiguresArea.Figures
{
    /// <summary>
    /// Постороение круга по радиусу
    /// </summary>
    public class Circle : IFigure
    {
        public double radius{ get; private set; }

        /// <param name="radius">Радиус</param>        
        public Circle(double radius)
        {
            if (radius <= .0)
            {
                throw new InvalidFigureParameters("Радиус должен быть больше 0.");
            }
            this.radius = radius;
            Area();
        }
        
        /// <summary>
        /// Рассчёт площади круга
        /// </summary>
        public double Area()
        {
            double area = .0;
            area = (Math.PI * Math.Pow(radius, 2));
            if (area == 0)
            {
                throw new InvalidFigureParameters("Площадь не может быть равна нулю");
            }
            return area;
        }
    }
}
