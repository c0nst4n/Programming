using UDK_Test_Release;

namespace MineSweeperApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UDK.Game.Launch(new MineSweeper());
            
        }
    }
}