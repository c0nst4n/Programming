using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    enum ObjType
    {
        BOMB,
        FLAG,
        CELL
    }
    internal class GameObject
    {
        private int _x;
        private int _y;
        private ObjType _type;
        public GameObject(int x, int y, ObjType type)
        {
            _x = x;
            _y = y;
            _type = type;
        }

        public int X => _x;
        public int Y => _y;
    }
}
