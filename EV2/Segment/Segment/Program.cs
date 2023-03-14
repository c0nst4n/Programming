namespace Segment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Segment2D Line1 = new Segment2D(new Point2D(0, 1), new Point2D(1,2));
            Segment2D Line2 = new Segment2D(new Point2D(2, 1), new Point2D(3, 4));
            Segment2D Line3 = new Segment2D(new Point2D(1, 0), new Point2D(2, 1));


            Console.WriteLine(Line1.CheckInteresction(Line3).x);
            Console.WriteLine(Line1.CheckInteresction(Line3).y);
        }
    }
}