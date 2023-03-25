using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public class MyCell
    {
        private bool _isFlag = false;
        private bool _isBomb = false;
        private bool _isOpen = false;
        public bool IsFlag => _isFlag;
        public bool IsBomb => _isBomb;
        public bool IsOpen => _isOpen;

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
    }
}
