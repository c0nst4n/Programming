namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library Bibliotuca = new Library();
            Book Metamorphosis= new Book(1850, "Franz Kafka", "Metamorphosis");
            Book Mamut = new Book(-80500, "Cavernicola", "Consejos para cazar mamuts");
            Book viejo = new Book(50, "Viejuno", "Libro viejo");
            Book NullBook = new Book(0, null, null);

            Bibliotuca.AddBook(Metamorphosis);
            Bibliotuca.AddBook(Mamut);
            Bibliotuca.AddBook(NullBook);
            Bibliotuca.AddBook(viejo);

            Console.WriteLine(Bibliotuca.GetBookAvg());
            

        }
    }
}