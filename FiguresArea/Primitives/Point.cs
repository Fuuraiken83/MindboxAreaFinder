using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  FiguresArea.Primitives
{
    /// <summary>
    /// Точка с заданными координатами
    /// </summary>
    public class Point
    {
        public double x { set; get; }
        public double y { set; get; }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
