namespace Granja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zone z = new Zone("Vietnam", "123A");
            Duck d = new Duck(true, "pipi", z, 10.50, new Date(2, 5, 2008, 20, 52, 2));
            Chicken c = new Chicken(true, "popo", z, 4.20, new Date(0, 0, 2013, 24, 60, 60), new Date(2, 5, 2008, 20, 52, 2));

            Stable stable = new Stable("Establolandia", "C/ Establos");
            stable.AddAnimal(d);

            Console.WriteLine(d.GetInfo() + "\n");
            Console.WriteLine(d.IsFlying() + "\n");
            Console.WriteLine(d.IsTerrestial() + "\n");

            Console.WriteLine(c.GetInfo() + "\n");
            Console.WriteLine(c.IsFlying() + "\n");
            Console.WriteLine(c.IsTerrestial() + "\n");






        }
    }
}