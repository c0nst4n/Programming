using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib
{
    public class Bishop : Figure
    {
        public Bishop(int x, int y, Color color, FigureType type) : base(x, y, color, type)
        {

        }
        public override FigureType GetFigureType()
        {
            throw new NotImplementedException();
        }
    }
}
