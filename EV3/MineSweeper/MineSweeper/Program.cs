namespace MineSweeper
{
    public class Program
    {
        static void Main(string[] args)
        {

         BiArrayBoard b = new BiArrayBoard();
            b.CreateBoard(5, 5);
            b.Init(0, 0, 15);

            b.WriteMineSweeper();
        }
    }
}