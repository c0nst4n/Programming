namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library Bibliotuca = new Library();

            Bibliotuca.AddBook(new Book(1850, "Franz Kafka", "Metamorphosis"));
            Bibliotuca.AddBook(new Book(-80500, "Cavernicola", "Consejos para cazar mamuts"));
            Bibliotuca.AddBook(new Book(0, null, null));

            Console.WriteLine(Bibliotuca.HasBookTitleYear("Metamorphosis", "Franz Kafka"));

        }
    }
}