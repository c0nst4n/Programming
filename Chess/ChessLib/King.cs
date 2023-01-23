using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib
{
    public class King : Figure
    {
        public King(int x, int y, Color color, FigureType type) : base(x, y, color, type)
        {

        }
        public override FigureType GetFigureType()
        {
            return FigureType.KING;
        }

        public  List<Position> GetAvailablePosition()
        {
            List<Position> position = new List<Position>();
            position.Add(new Position(x + 1, y)); //derecha
            position.Add(new Position(x, y + 1)); // arriba
            position.Add(new Position(x -1, y)); // izq
            position.Add(new Position(x, y - 1)); // abajo
            position.Add(new Position(x - 1, y - 1)); // abajo izq
            position.Add(new Position(x + 1, y + 1)); //arriba der
            position.Add(new Position(x + 1, y - 1)); // abajo der
            position.Add(new Position(x - 1, y + 1)); // arriba izq
            return position;


        }
    }
}
