using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib
{
    public class Pawn : Figure
    {
        public Pawn(int x, int y, Color color, FigureType type) : base(x, y, color, type)
        {

        }
        public override FigureType GetFigureType()
        {
            return FigureType.PAWN;
        }


        public List<Position> GetAvailablePosition()
        {
            List<Position> position = new List<Position>();
            if (GetColor == Color.WHITE)
            {
                position.Add(new Position(x, y + 2));
                position.Add(new Position(x, y + 1));
                position.Add(new Position(x + 1, y + 1));
                position.Add(new Position(x - 1, y + 1));
            }
           

            if (GetColor == Color.BLACK)
            {
                position.Add(new Position(x, y - 2));
                position.Add(new Position(x, y - 1));
                position.Add(new Position(x - 1, y - 1));
                position.Add(new Position(x + 1, y - 1));

            }
                
            return position;
        }
    }
}
