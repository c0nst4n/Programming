using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceSimulation
{
    internal class utils
    {
        private static Random random = new Random();
        public static  double  GetRandom(double min, double max)
        {
            double dis = max - min;
            double getRan = dis * random.NextDouble();
            return getRan + min;
        }
    }
}
