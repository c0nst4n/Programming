using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib
{
   public enum Color
    {
        BLACK,
        WHITE
    }

   public enum FigureType
    {
        PAWN,
        KNIGHT,
        BISHOP,
        TOWER,
        QUEEN,
        KING
    }
    public abstract class Figure
    {
       internal int x, y;
        Color color;
        FigureType type;
        public Figure(int x, int y, Color color, FigureType type)
        {
            this.x = x;
            this.y = y;
            this.color = color;
            this.type = type;
        }

        public int X
        {
            get
            {
                return x;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
        }

    

        public FigureType Type
        {
            get
            {
                return GetFigureType();
            }
        }

        public abstract FigureType GetFigureType();

      
    }
}
