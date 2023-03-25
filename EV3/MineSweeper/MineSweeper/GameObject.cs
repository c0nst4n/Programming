using System;


namespace MineSweeper
{
    public enum ObjType
    {
        BOMB,
        FLAG,
        CELL
    }
    public class GameObject
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
