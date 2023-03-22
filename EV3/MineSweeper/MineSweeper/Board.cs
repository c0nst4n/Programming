using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    internal class Board:IBoard
    {
       private List<Bomb> _bombList= new List<Bomb>();
       private List<Flag> _flagList= new List<Flag>();
       private List<Cell> _openCellList = new List<Cell>();
       private int _width;
       private int _height;
       private Random _rand = new Random();
        //Bombas
        public int GetBomb(int x, int y)
        {
            for (int i = 0; i < _bombList.Count; i++)
            {
                if (_bombList[i].X == x && _bombList[i].Y == y)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool IsBombAt(int x, int y)
        {
            return (GetBomb(x, y) != -1);

        }
        public void ActivateBomb(int x, int y)
        {
            if (GetBomb(x, y) != -1)
            {
                _bombList[GetBomb(x, y)].Activate();
            }
        }

        public void DeactivateBomb(int x, int y)
        {
            if (GetBomb(x, y) != -1)
            {
                _bombList[GetBomb(x, y)].Deactivate();
            }
        }

        //Banderas
        public bool IsFlagAt(int x, int y)
        {
            if (_flagList.Count != 0)
            {
                for (int i = 0; i < _flagList.Count; i++)
                {
                    if (_flagList[i].X == x && _flagList[i].Y == y)
                    {
                        return true;
                    }
                }
        
            }
            return false;

        }

        public void PutFlagAt(int x, int y)
        {
            if (!IsFlagAt(x, y))
            {
                _flagList.Add(new Flag(x, y));
                if (IsBombAt(x, y))
                    DeactivateBomb(x, y);
            }

        }

        public void DeleteFlagAt(int x, int y)
        {
            for (int i = 0; i != _flagList.Count; i++)
            {
                if (_flagList[i].X == x && _flagList[i].Y == y)
                {
                    if (IsBombAt(x, y))
                        ActivateBomb(x, y);
                    _flagList.RemoveAt(i);
                    i--;
                }
            }
        }
        //Casillas

        public int GetCell(int x, int y)
        {
            for (int i = 0; i < _openCellList.Count; i++)
            {
                if (_openCellList[i].X == x && _openCellList[i].Y == y)
                {
                    return i;
                }
            }
            return -1;
        }
        public bool IsCellOpen(int x, int y)
        {
            if (GetCell(x, y) != -1)
                return _openCellList[GetCell(x, y)].IsOpen;
            return false;
        }

        public void OpenCell(int x, int y)
        {
            _openCellList.Add(new Cell(x, y, true));
        }

        //Juego
        public void CreateBoard(int width, int height)
        {
            _width = width; 
            _height = height;
            _bombList.Clear();
            _openCellList.Clear();
            _flagList.Clear();
        }

        public void Init(int x, int y, int bombNumber)
        {
            for(int i = 0; i < bombNumber; i++)
            {
                int sum = _rand.Next(-5, 5);
                _bombList.Add(new Bomb(x + sum, y + sum));
            }
        }

        public bool GetWin()
        {
            bool bombs = true;
            bool cells = true;

            for(int i = 0; i <_bombList.Count; i++)
            {
                if (_bombList[i].IsActive == true)
                    bombs = false;
            }

            if (_openCellList.Count != _width * _height)
                cells = false;

            return (bombs == true && cells == true);
               
        }

    }
}
