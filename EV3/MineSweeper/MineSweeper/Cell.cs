using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    internal class Cell:GameObject
    {
        private int _bombs;
        private bool _isOpen = false;
        public int Bombs => _bombs;
        public bool IsOpen => _isOpen;
        public Cell(int x, int y, bool isOpen):base(x, y, ObjType.CELL)
        {
            _isOpen= isOpen;
        }

        public int GetBombProximity(List<Bomb> bl, int x, int y)
        {
            int result = 0;
            for(int i = 0; i < bl.Count; i++)
            {
                if (bl[i].X == x + 1 || bl[i].X == x - 1 || bl[i].Y == y + 1 || bl[i].Y == y - 1)
                {
                    result++;
                }
            }
            return result;
        }

        public void OpenCell()
        {
            _isOpen= true;
        }
    }
}
