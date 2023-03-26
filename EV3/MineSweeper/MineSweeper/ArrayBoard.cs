using System;


namespace MineSweeper
{
    public class ArrayBoard:Board
    {
        private MyCell[] _cellArray = new MyCell[0];
        #region FUNCIONES
        public override void Add()
       {
            MyCell[] result = new MyCell[_cellArray.Length + 1];
            
            for (int i = 0; i < _cellArray.Length; i++)
            {
                result[i] = _cellArray[i];
            }

            result[_cellArray.Length] = new MyCell();
            _cellArray = result;
       }


        public override MyCell GetCellAt(int x, int y)
        {
            int pos = PosToArray(x, y);

            return _cellArray[pos];
        }
        public override int  CheckListSize()
        {
            return _cellArray.Length;
        }
       public override void RenewList()
       {
          
            _cellArray = new MyCell[0];
       }
        #endregion
    }
}
