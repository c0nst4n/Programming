using System;

namespace MineSweeper
{
    public abstract class Board : IBoard
    {
        #region VARIABLES
        protected int heigth;
        protected int width;
        #endregion
        #region FUNCIONES PARA HIJOS
        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        {
            return heigth;
        }


        abstract public void Add(); //Añade una casilla nueva a la lista o casilla

        abstract public MyCell GetCellAt(int x , int y); //Devuelve una casilla dada su posición
        public int PosToArray(int x, int y) //Convierte una posición x y en una posición de array/lista
        {
            return x + y * width;
        }

        abstract public int CheckListSize(); //Devuelve el tamaño de la lista/ array
        public (int, int) ArrayToPos(int pos)
        {
            int y = pos / width;
            int x = pos % width;
            return (x, y);
        }

        public bool IsFirstCell() //Pregunta si la casilla que se va ha abrir es la 1era casilla abierta
        {
            for (int i = 0; i < GetWidth(); i++)
            {
                for (int j = 0; j < GetHeight(); j++)
                {
                    if (IsCellOpen(i,j))
                        return false;
                }
            }
            return true;
        }
        //Vacía la lista/array
        abstract public void RenewList();
        #endregion
        #region FUNCIONES
        public void CreateBoard(int w, int h)
        {
            width = w;
            heigth = h;
            RenewList();
            for (int i = 0; i < w * h; i++)
            {
                Add();
            }
                
        }

        

        public void DeleteFlagAt(int x, int y)
        {
            GetCellAt(x, y).DeleteFlag();
        }

        public void Init(int x, int y, int bombCount)
        {
            if (!IsFirstCell())
                return;
        
            for (int i = 0; i < bombCount; i++)
            {
                int Xrand = Utils.rand.Next(0, width);
                int Yrand = Utils.rand.Next(0, heigth);

                if (IsBombAt(Xrand,Yrand) || (Xrand == x && Yrand == y))
                {
                    i--;
                    continue;
                }

                GetCellAt(Xrand, Yrand).PutBomb();
            }
        }

        public bool IsBombAt(int x, int y)
        {
            return GetCellAt(x, y).IsBomb;
        }

        public bool IsCellOpen(int x, int y)
        {
            return GetCellAt(x, y).IsOpen;
        }

        public bool IsFlagAt(int x, int y)
        {
            return GetCellAt(x, y).IsFlag;
        }

        public void OpenCell(int x, int y)
        {
            GetCellAt(x, y).Open();
        }

        public void PutFlagAt(int x, int y)
        {
            GetCellAt(x, y).PutFlag();
        }

        public void WriteMineSweeper()
        {
            IBoard b = this;
            for (int i = 0; i < GetWidth(); i++)
            {
                for (int j = 0; j < GetHeight(); j++)
                {
                    if (IsFlagAt(i, j))
                        Console.Write("P");
                    else if (IsBombAt(i, j))
                        Console.Write("O");
                    else
                        Console.Write(b.GetBombProximity(i, j));
                }
                Console.Write("\n");
            }
        }
        #endregion
    }
}
