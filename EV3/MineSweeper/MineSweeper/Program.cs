namespace MineSweeper
{
    public class Program
    {
        static void Main(string[] args)
        {
           ArrayBoard board = new ArrayBoard();
            board.CreateBoard(20, 20);
            board.Init(0, 0, 5);
            board.WriteMineSweeper();
        }
    }
}