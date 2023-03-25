using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    public class Utils
    {
        private static Random _rand = new Random();
        public static Random rand => _rand;
    }
}
