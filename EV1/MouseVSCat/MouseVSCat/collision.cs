using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseVSCat
{
    internal class collision
    {

        public bool checkCollision(float x1, float x2, float y1, float y2, float w1, float w2, float h1, float h2)
        {
            float xmax1 = x1 + w1;
            float xmax2 = x2 + w2;
            float ymax1 = y1 + h1;
            float ymax2 = y2 + h2;

            if (x1 > xmax2)
                return false;
            if (xmax2 > x1)
                return false;
            if (y1 > ymax2)
                return false;
            if (ymax2 > y1)
                return false;



            return true;

        }

    }
}
