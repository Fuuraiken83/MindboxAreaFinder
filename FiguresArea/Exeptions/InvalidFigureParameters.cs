using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Ошибка при задании параметров фигуры
/// </summary>
namespace FiguresArea.Exeptions
{
    [Serializable]
    public class InvalidFigureParameters : Exception
    {
        public InvalidFigureParameters(string msg)
            : base(msg)
        {

        }
    }
}
