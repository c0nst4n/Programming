using System;

namespace MineSweeper
{
    public class Bomb:GameObject
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
