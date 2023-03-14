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
            return FigureType.BISHOP;
        }

        public List<Position> GetAvailablePosition()
        {
            List<Position> position = new List<Position>();
            for(int i=0; i <= 7; i++) //Arriba Derecha
            {
                position.Add(new Position(x + i, y + i));
            }
            
            for (int i=0; i<= 7; i++) // Abajo Izquierda
            {
                position.Add(new Position(x - i, y - i));
            }
            
            for (int i=0; i<=7; i++) //
            {
                position.Add(new Position(x - i, y + i));
            }
            
            position.Add(new Position(x + 7, y - 7));
            return position;

        }
    }
}
