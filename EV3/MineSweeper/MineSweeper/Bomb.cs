using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    internal class Bomb:GameObject
    {
        private bool _isActive = true;
        public bool IsActive => _isActive;
        public Bomb(int x, int y):base(x, y, ObjType.BOMB)
        {

        }

        public void Activate()
        {
            _isActive = true;
        }
        public void Deactivate()
        {
            _isActive = false;
        }
    }
}
