using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib
{
    public class Knight : Figure
    {
        public Knight(int x, int y, Color color, FigureType type) : base(x, y, color, type)
        {
            

        }
        public override FigureType GetFigureType()
        {
            return FigureType.KNIGHT;
        }

        public  List<Position> GetAvailablePosition()
        {
            List<Position> list = new List<Position>();
            list.Add(new Position(x + 1, y + 2));
            list.Add(new Position(x - 1, y + 2));
            list.Add(new Position(x + 1, y - 2));
            list.Add(new Position(x - 1, y - 2));
            list.Add(new Position(x + 2, y + 1));
            list.Add(new Position(x - 2, y + 1));
            list.Add(new Position(x + 2, y - 1));
            list.Add(new Position(x - 2, y - 1));

            return list;
        }


    }
}
