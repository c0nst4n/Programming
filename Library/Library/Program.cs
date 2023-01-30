namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library Bibliotuca = new Library();
            Book Metamorphosis= new Book(1850, "Franz Kafka", "Metamorphosis");
            Book Mamut = new Book(-80500, "Cavernicola", "Consejos para cazar mamuts");
            Book NullBook = new Book(0, null, null);

            Bibliotuca.AddBook(Metamorphosis);
            Bibliotuca.AddBook(Mamut);
            Bibliotuca.AddBook(NullBook);

            Console.WriteLine(Bibliotuca.HasBookTitleYear("Metamorphosis", "Franz Kafka"));
            

        }
    }
}