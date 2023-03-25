using System;


namespace MineSweeper
{
    public interface IBoard
    {
        //Juego

        int GetWidth();

        int GetHeight();
        void CreateBoard(int w, int h);
        void Init(int x, int y, int bombCount);

        bool HasWin() //Debería echar un vistazo a esto
        {
          for (int i = 0; i < GetWidth(); i++)
            {
                for(int j = 0; j < GetHeight(); j++)
                {
                    if(!IsCellOpen(i, j) && !IsBombAt(i,j))
                        return false;
                }
            }
            return true;
        }

        void WriteMineSweeper();
        
        //Bombas
        bool IsBombAt(int x, int y);
        int GetBombProximity(int x, int y) 
        {
            int counter = 0;
            while(true)
            {
                if (IsBombAt(x + 1, y + 1))
                    counter++;
                if (IsBombAt(x, y + 1))
                    counter++;
                if (IsBombAt(x, y - 1))
                    counter++;
                if (IsBombAt(x + 1, y))
                    counter++;
                if (IsBombAt(x - 1, y))
                    counter++;
                if (IsBombAt(x - 1, y - 1))
                    counter++;
                if (IsBombAt(x + 1, y -1))
                    counter++;
                if (IsBombAt(x - 1, y + 1))
                    counter++;
                break;
            }
            return counter;
        }
        //Banderas
        bool IsFlagAt(int x, int y);
        void PutFlagAt(int x, int y);
        void DeleteFlagAt(int x, int y);
        //Casillas
        bool IsCellOpen(int x, int y);
        void OpenCell(int x, int y);

    }
}
