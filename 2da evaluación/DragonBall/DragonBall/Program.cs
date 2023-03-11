namespace DragonBall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tournament Budokai= new Tournament();
            Budokai.Init();
            
            Budokai.SeeResults();
            
        }
    }
}