using System;

namespace MineSweeper
{
    public abstract class Board : IBoard
    {
        protected int heigth;
        protected int width;

        
        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        {
            return heigth;
        }
        //Funcones para hijos
        abstract public void Add();

        abstract public MyCell GetCellAt(int x , int y);
        public int PosToArray(int x, int y)
        {
            return x + y * width;
        }

        abstract public int CheckListSize();
        public (int, int) ArrayToPos(int pos)
        {
            int y = pos / width;
            int x = pos % width;
            return (x, y);
        }

        public bool IsFirstCell()
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

        abstract public void RenewList();
        //Fin de las funciones para hijos
        public void CreateBoard()
        {
            RenewList();
            for (int i = 0; i < width * heigth; i++)
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

                if (!IsBombAt(Xrand, Yrand) || !(Xrand == x && Yrand == y))
                {
                    GetCellAt(x, y).PutBomb();
                }
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
    }
}
