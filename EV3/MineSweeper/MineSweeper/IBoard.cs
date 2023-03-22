using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    internal interface IBoard
    {
        //Juego
        void CreateBoard(int w, int h);
        void Init(int x, int y, int bombCount);

        bool HasWin() //Debería echar un vistazo a esto

        {
          return GetWin();
        }

        bool GetWin();
        //Bombas
        int GetBomb(int x, int y);
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
        void DeactivateBomb(int x, int y);
        void ActivateBomb(int x, int y);
        //Banderas
        bool IsFlagAt(int x, int y);
        void PutFlagAt(int x, int y);
        void DeleteFlagAt(int x, int y);
        //Casillas
        bool IsCellOpen(int x, int y);
        void OpenCell(int x, int y);
        int GetCell(int x, int y);
    }
}
