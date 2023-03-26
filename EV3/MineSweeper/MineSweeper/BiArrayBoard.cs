using System;


namespace MineSweeper
{
    internal class BiArrayBoard:Board
    {
        private MyCell[,] _cellArray;
        #region FUNCIONES
        public override MyCell GetCellAt(int x, int y)
        { 
            return _cellArray[x, y];
        }
        public override int CheckListSize()
        {
            return width * heigth;
        }
        public override void RenewList()
        {
            _cellArray = new MyCell[width ,heigth];
        }
        public override void Add()
        {
            for(int i = 0; i < width; i++)
            {
                for (int j = 0; j < heigth; j++)
                {
                    if ( _cellArray[i,j] == null)
                    {
                        _cellArray[i,j] = new MyCell();
                        break;
                    }
                }
            }
        }
        #endregion
    }
}
