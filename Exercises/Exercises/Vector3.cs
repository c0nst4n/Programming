using System;
namespace Exercises
{
    internal class Vector3
    {
        public double x;
        public double y;
        public double z;

        public double GetModule()
        {
            double x2 = this.x * this.x;
            double y2 = this.y * this.y;
            double z2 = this.z * this.z;

            return Math.Sqrt(x2 + y2 + z2);

        }

    }

    
}
