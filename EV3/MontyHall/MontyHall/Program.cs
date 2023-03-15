namespace MontyHall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Console.WriteLine(game.Execute(false));
        }
    }
}