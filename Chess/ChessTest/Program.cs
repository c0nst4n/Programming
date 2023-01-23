using ChessLib;
using System.Security.Cryptography.X509Certificates;

namespace ChessTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board tablero = new Board();
            Bishop b = new Bishop(2, 3, Color.WHITE, FigureType.BISHOP);

            Console.WriteLine(tablero.GetFigurePos(b));

        }
    }
}