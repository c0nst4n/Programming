namespace Neighbour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House casa = new House();
           
            Console.WriteLine(casa.RemovePersonByName(null));
        }
    }
}