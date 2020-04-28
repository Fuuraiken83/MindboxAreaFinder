using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiguresArea.Primitives;

namespace  FiguresArea.Interfaces
{
    /// <summary>
    /// Построение фигуры по заданым по очереди координатам
    /// </summary>
    interface IFigureByPoints
    {
        Point[] points { get;}
    }
}
