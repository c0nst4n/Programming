using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Library
    {
       private List<Book> _BookList = new List<Book>();

        public int BookQuantity 
        {
            get => _BookList.Count;
        }

        public void AddBook(Book AddBook) 
        { 
            _BookList.Add(AddBook); 
        }

        public bool HasBook(Book Input)
        {
            return _BookList.Contains(Input);
        }

        public bool HasBookTitleYear(string Title, string Author)
        {
        

            for (int i = 0; i < _BookList.Count; i++)
            {

                if (_BookList[i].Author == Author && _BookList[i].Title == Title)
                    return true;

                if (_BookList[i].Title == Title && _BookList[i].Author == null)
                    return true;
                if (_BookList[i].Title == null && _BookList[i].Author == Author)
                    return true;


            }

            return false;
        }

        public bool DeleteBookByTitle(string title)
        {
            for(int i = 0; i < _BookList.Count - 1; i++)
            {
                if (_BookList[i].Title == title)
                {
                    _BookList.RemoveAt(i);
                    return true;
                }
            }

            return false;
        }
        public bool DeleteBookTitleYear(string Title, string Author)
        {

            for (int i = 0; i < _BookList.Count; i++)
            {

                if (_BookList[i].Title == Title && _BookList[i].Author == Author)
                {
                    _BookList.RemoveAt(i);
                    return true;

                }
               

                if (_BookList[i].Title == Title && _BookList[i].Author == null)
                {
                    _BookList.RemoveAt(i);
                    return true;
                }
          
                if (_BookList[i].Title == null && _BookList[i].Author == Author)
                {
                    _BookList.RemoveAt(i);
                    return true;
                }
                   


            }
            return false;
        }

        public int DeleteBooks(string Title, string Author)
        {
            int deletedBooks = 0;
            for (int i = 0; i < _BookList.Count; i++)
            {

                if (_BookList[i].Title == Title && _BookList[i].Author == Author)
                {
                    _BookList.RemoveAt(i);
                    deletedBooks++;

                }


                if (_BookList[i].Title == Title && _BookList[i].Author == null)
                {
                    _BookList.RemoveAt(i);
                    deletedBooks++;
                }

                if (_BookList[i].Title == null && _BookList[i].Author == Author)
                {
                    _BookList.RemoveAt(i);
                    deletedBooks++;
                }



            }
            return deletedBooks;
        }

        public void DeleteAll()
        {
            _BookList.Clear();
        }

        public Library CloneLibrary()
        {
            Library newLibrary = new Library();
            newLibrary._BookList = _BookList;
            return newLibrary;
            
        }

    }
}
