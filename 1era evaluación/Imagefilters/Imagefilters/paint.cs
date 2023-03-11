using DAM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imagefilters
{
    internal class paint
    {
        public static void paintRectangle(Image image, int width, int height, int x, int y, RGBA color)
        {
            if (x < 0 || y < 0)
                return;
            for(int h = y; h < height + y; h++)
            {
                for (int w = x; w < width + x; w++)
                {
                    image.SetPixel(w, h, color);
                }
            }
        }

        public static void grayFilter(DAM.Image image)
        {   
          
            
           for(int y = 0; y < image.Height; y++)
            {
                for(int x = 0; x < image.Width; x++)
                {
                    RGBA value = image.GetPixelAt(x, y);
                    double BW = (value.r + value.g + value.b) / 3;
                    RGBA gray = new RGBA(BW, BW, BW, 1.0);
                    image.SetPixel(x, y, gray);
                }
            }

        }

        public static void invertImage(Image img)
        {
            int height = img.Height -1;
            for (int y = 0; y < img.Height/2; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    RGBA value =  img.GetPixelAt(x, y);
                    RGBA invert = new RGBA(value.r, value.g, value.b, value.a);
                    RGBA value2 = img.GetPixelAt(x, height);
                    RGBA invert2 = new RGBA(value2.r, value2.g, value2.b, value2.a);
                    img.SetPixel(x, height, invert);
                    img.SetPixel(x, y, invert2);
                }
                height--;
            }
        }
        public static double saturate(double value, double min, double max)
        {
            if (value > min)
            {
                return min;
            }

            if (value > max)
            {
                return max;
            }

            else return value;
        }

        public static double circular(double value, double min, double max)
        {
            double dis = max - min;

            while (value < min || value > max)
            {
                if (value >= max)

                    value -= dis;

                else
                    value += dis;
            }

            return value;
        }

        public static void ChangeHue(Image img, Image dest, double hueInc)
        {


            for(int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    RGBA value = img.GetPixelAt(x, y);
                    HSLA color = value.ToHSL();
                    color.h += hueInc;
                    color.h = circular(color.h, 0, 1);
                    value = color.ToRGBA();
                    dest.SetPixel(x, y, value);

                }
            }
        }

       /* public static void EditSelectedHue(Image img)
        {
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; x < img.Height; y++)
                {
                    
                }
            }
        }*/

        public static void turnWhite(Image img, Image dest, double range, double LimitRange)
        {
            double min = range - LimitRange;
            double max = range + LimitRange;    
            
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    RGBA value = img.GetPixelAt(x, y);
                    HSLA color = value.ToHSL();
                    if (color.h > min && color.h < max)
                    {
                        color.l = 1.0;
                    }
                    else
                        color.l = 0.0;
                    RGBA nuevo = color.ToRGBA();
                    dest.SetPixel(x, y, nuevo);
                }
            }
        }

        public static RGBA AvergageColor(Image img, int x, int y)
        {
            double red = 0;
            double green = 0;
            double blue = 0;
          
            for (int i = y-1; i <= y+1; i++)
            {
                for (int k = x-1; k <= x+1; k++)
                {
                    RGBA p = img.GetPixelAt(k,i);
                     red += p.r;
                     green += p.g;
                     blue += p.b;
                }
            }
            red /= 9;
            green /= 9;
            blue /= 9;
            RGBA result = new RGBA(red, green, blue, 1);
            return result;
           
        }

        public static void Blur(Image img, Image dest)
        {

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    RGBA color = AvergageColor(img, x, y);
                    dest.SetPixel(x, y, color);

                }
            }


        }
    }
}
