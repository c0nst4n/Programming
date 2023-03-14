using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        string _title;
        string _author;
        int _year;

        public string Title
        {
            get => _title;

            set => _title = value;
        }

        public string Author
        {
            get => _author;

            set => _author = value;
        }

        public int Year
        {
            get => _year;

            set => _year = value;
        }

        public Book() { }

        public Book(int Year, string Author, string Title) 
        {
            _year = Year;
            _author = Author;
            _title = Title;
        }

        public bool IsOld()
        {
            return _year < 1500;
        }

        public bool IsValid()
        {
            return _author != null && _title != null && _year <= 0;
        }

        public Book CloneBook()
        {
            return new Book(_year, _author, _title);
            
        }

        
    }
}
