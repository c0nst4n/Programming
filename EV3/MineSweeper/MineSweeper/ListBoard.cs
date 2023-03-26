using System;


namespace MineSweeper
{
    public class ListBoard:Board
    {
       private List<MyCell> _cellList= new List<MyCell>();
        #region FUNCIONES
        public override MyCell GetCellAt(int x, int y)
        {
            int pos = PosToArray(x, y);

            return _cellList[pos];
        }
        public override int CheckListSize()
        {
            return _cellList.Count;
        }
        public override void RenewList()
        {
            _cellList.Clear();
        }
        public override void Add()
        {
           _cellList.Add(new MyCell());
        }
        #endregion

    }
}
