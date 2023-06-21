namespace Dardos
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Game game= new Game();
            game.InsertPlayer(new Player("A", 1, 3));
            game.InsertPlayer(new Player("B", 2, 20));
            game.InsertPlayer(new Player("C", 3, 1));
            game.InsertPlayer(new Player("D", 4, 4));

            Console.WriteLine(game.Play());
            
            
        }
    }
}