namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle a = new Rectangle(5,5,0,0);
            Rectangle b = new Rectangle(5,5,1,1);

            Console.WriteLine(a.IntersectsWith(b));
        }
    }
}