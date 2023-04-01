using System;

namespace MineSweeper
{
    public class MyCell
    {
        #region VARIABLES
        private bool _isFlag = false;
        private bool _isBomb = false;
        private bool _isOpen = false;
        #endregion

        #region GETTERS
        public bool IsFlag => _isFlag;
        public bool IsBomb => _isBomb;
        public bool IsOpen => _isOpen;  
        #endregion

        #region FUNCIONES
        public void PutBomb()
        {
            _isBomb = true;
        }
        public void Open()
        {
            _isOpen = true;
        }

        public void PutFlag()
        {
            _isFlag = true;
        }

        public void DeleteFlag()
        {
            _isFlag = false;
        }

        public void Close()
        {
            _isOpen = false;
        }
        #endregion
    }
}
