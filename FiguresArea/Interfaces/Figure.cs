using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresArea.Interfaces
{
    /// <summary>
    /// Интерфейс с общими для всех фигур параметрами вроде площади
    /// </summary>
    public interface IFigure
    {
        double Area();
    }
}
