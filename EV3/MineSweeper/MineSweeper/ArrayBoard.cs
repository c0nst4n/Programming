using System;


namespace MineSweeper
{
    public class ArrayBoard:Board
    {
        private MyCell[] _cellArray;

       public override void Add()
       {
            MyCell[] result = new MyCell[_cellArray.Length + 1];
            
            for (int i = 0; i < _cellArray.Length; i++)
            {
                result[i] = _cellArray[i];
            }

            result[_cellArray.Length + 1] = new MyCell();
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
            int size = width * heigth;
            _cellArray = new MyCell[size];
       }

        //public void CreateBoard(int w, int h)
        //{
        //    if (w <= 0 || h <= 0)
        //        throw new Exception("ESTO NO ES FISICAMENTE POSIBLE");

        //    width = w;
        //    heigth = h;
        //    int size = w * h;
        //    _cellArray = new MyCell[size];
        //    for (int i = 0; i < size; i++)
        //    {
        //        _cellArray[i] = new MyCell();
        //    }
        //}

        //public void Init(int x, int y, int bombCount)
        //{
        //    for (int i = 0; i <= bombCount; i++)
        //    {
        //        int sum = Utils.rand.Next(-5, 5);
        //        int randpos = PosToArray(x + sum, y + sum);
        //        _cellArray[randpos].PutBomb();
        //    }
        //}

        //public bool GetWin()
        //{
        //    for (int i = 0; i < _cellArray.Length; i++)
        //    {
        //        if (_cellArray[i].IsBomb == true)
        //            return false;
        //    }
        //    return true;
        //}

        //public bool IsBombAt(int x, int y)
        //{
        //    int index = PosToArray(x, y);
        //    return _cellArray[index].IsBomb;
        //}


        //public bool IsFlagAt(int x, int y)
        //{
        //    int index = PosToArray(x, y);
        //    return _cellArray[index].IsFlag;
        //}

        //public void PutFlagAt(int x, int y)
        //{
        //    int index = PosToArray(x,y);
        //    _cellArray[index].PutFlag();
        //}

        //public void DeleteFlagAt(int x, int y)
        //{
        //    int index = PosToArray(x,y);
        //    _cellArray[index].DeleteFlag();
        //}

        //public bool IsCellOpen(int x, int y)
        //{
        //    int index = PosToArray(x,y);
        //   return _cellArray[index].IsOpen;
        //}

        //public void OpenCell(int x, int y)
        //{
        //    int index = PosToArray(x, y);
        //    _cellArray[index].Open();
        //}

    }
}
