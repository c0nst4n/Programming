using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib
{
    public class Tower : Figure
    {
        public Tower(int x, int y, Color color, FigureType type) : base(x, y, color, type)
        {

        }
        public override FigureType GetFigureType()
        {
            return FigureType.TOWER;
        }

        public List<Position> GetAvailablePosition()
        {
            List<Position> position = new List<Position>();
            for(int i= 0; i <= 7; i++)//Derecha
            {
                position.Add(new Position( x + i, y));
            }
            for (int i = 0; i <= 7; i++)//Izquierda
            {
                position.Add(new Position(x - i, y));
            }
            for (int i = 0; i <= 7; i++)//Arriba
            {
                position.Add(new Position(x, y + i));
            }
            for (int i = 0; i <= 7; i++)//Abajo
            {
                position.Add(new Position(x, y - i));
            }

            return position;
        }
    }
}
