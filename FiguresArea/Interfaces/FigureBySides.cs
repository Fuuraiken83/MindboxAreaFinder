using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresArea.Interfaces
{
    /// <summary>
    /// Построение фигуры по заданным длинам сторон
    /// </summary>
    interface IFigureBySides
    {
        double[] sides { get; }
    }
}
