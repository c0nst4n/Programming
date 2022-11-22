using DAM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseVSCat
{
    public class character
    {
        public float x, y, width, height;
        public float r, g, b, a;
        public CharacterType type;
        public DAM.Image image;
        
        
        public void Render(ICanvas canvas)
        {
            canvas.FillRectangle(x - width / 2, y - height / 2, width, height, image, 0, 0, 1, 1, 1, 1, 1, 0.99f);

        }
    }

   public enum CharacterType
    {
        CAT, MOUSE
    }


}
