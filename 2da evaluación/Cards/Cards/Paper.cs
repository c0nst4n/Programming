using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public enum CardType
    {
        GOLD,
        CUPS,
        SWORDS,
        STICK
    }
    public class Paper
    {
        private int _number;
        private CardType _type;
        

        public int Num => _number;
    
        public  CardType CType => _type;

        public Paper() { }

        public Paper(int number, CardType type)
        {
            _number = number;
            _type = type;
        }
    }
}
