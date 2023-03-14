using DAM;
namespace Imagefilters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\costa\\Desktop\\images\\";
            string in_path = path + "coch-rojo.jpg";
            string out_path = path + "Blurreado.jpg";
            Image img = new Image();
             img.Load(in_path);

             Image nueva = new Image();
             nueva.Config(img.Width, img.Height);
             paint.Blur(img, nueva);

             nueva.Save(out_path);

        }

        static void test1()
        {
            string path = "C:\\Users\\costa\\Desktop\\images\\test3.png";
            Image img = new Image();
            img.Config(800, 600, new RGBA(1.0, 0.0, 0.0, 1.0));
            img.Save(path);
            paint.paintRectangle(img, 40, 60, 100, 55, new RGBA(1.0, 0.5, 0.8, 1.0));
            img.Save(path);
        }

        static void test2()
        {
            string path = "C:\\Users\\costa\\Desktop\\images\\";
            string in_path = path + "a.png";
            string out_path = path + "bw.png";
            Image img = new Image();
            img.Load(in_path);

            

            img.Save(out_path);
        }
    }

}