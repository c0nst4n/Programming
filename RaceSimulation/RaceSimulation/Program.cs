namespace RaceSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Racer winner = null;
            List<Racer> list = Simulation.GenerateRacers();
            while (winner == null)
            {
                Simulation.Run(list);
                winner = Simulation.CheckWinner(list);
                 
            }
            Console.WriteLine(winner.name);
        }
    }
}