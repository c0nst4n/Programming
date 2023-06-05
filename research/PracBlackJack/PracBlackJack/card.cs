using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracBlackJack
{
    public class card
    {
        private int _value;
        
        public card(int value) 
        {
            _value = value;
        }

        public int GetValue()
        {
            return _value;
        }
    }
}
