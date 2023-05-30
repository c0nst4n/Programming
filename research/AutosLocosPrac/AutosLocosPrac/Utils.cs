using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutosLocosPrac
{
    public static class Utils
    {
       public static Random rand= new Random();

        public static double DoubleRand(double min, double max)
        {
            if (min > max)
                DoubleRand(max, min);

            return rand.NextDouble() * (max - min) + min;
        }
    }
}
