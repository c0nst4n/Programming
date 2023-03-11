using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib
{
    public class Queen : Figure
    {
        public Queen(int x, int y, Color color, FigureType type) : base(x, y, color, type)
        {

        }
        public override FigureType GetFigureType()
        {
            return FigureType.QUEEN;
        }
    }
}
