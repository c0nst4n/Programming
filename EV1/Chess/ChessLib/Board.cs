using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib
{
    public class Board
    {
        int x = 7;
        int y = 7;

        
        public List<Figure> list = new List<Figure>();
        public Board()
        {
           for(int i = 1; i <= 8; i++)
            {

                list.Add(new Pawn(i, 2, Color.WHITE, FigureType.PAWN));
            }  
        }

       public  (int, int) GetFigurePos(Figure figure)
        {
            return (figure.X, figure.Y);
        }
       
    }
}
