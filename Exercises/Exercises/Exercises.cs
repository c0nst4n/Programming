using System;

namespace Exercises
{
    internal class Exercises
    {
        public static bool IsEven(int a)
        {
            return a % 2 == 0;
        }

        public static bool IsCousin(int a)
        {

            for (int i = 2; i < a; i++)
            {
                if ((a % i) == 0)
                    return false;

            }

            return true;
        }

        public static double GetAreaCir(double rad)
        {

            return Math.PI * (rad * rad);
        }

        public static double GetAreaRec(double a, double b)
        {
            return a * b;
        }

        public static double GetDistance(double ax, double bx, double ay, double by)
        {
           
        }
    }

}
