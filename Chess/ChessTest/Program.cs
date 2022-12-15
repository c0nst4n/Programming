using ChessLib;
using System.Security.Cryptography.X509Certificates;

namespace ChessTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bishop b = new Bishop(30, 5, Color.BLACK, FigureType.BISHOP);
           

            Console.WriteLine(b.X);
        }
    }
}