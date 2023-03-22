using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    internal class Flag:GameObject
    {
        public Flag(int x, int y):base(x, y, ObjType.FLAG)
        {

        }
    }
}
