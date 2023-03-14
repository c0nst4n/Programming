using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public class Utils
    {
       private static Random _random = new Random();

        public Random rand => _random;


        public static int GetRandomInteger(int min, int max)
        {
            return _random.Next(min - 1, max + 1);
        }

        public static double GetRandomReal(double min, double max)
        {
            return _random.Next()*(min - (max+1) + max + 1);
        }

       
    }
}
