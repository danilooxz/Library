using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace APP02
{
  
    class Book
    {
        public string BookName;
        public string AuthorName;
        public int NumberPage;

        public Book(string bookName, string authorName, int numberPage)
        {
            BookName = bookName;
            AuthorName = authorName;
            NumberPage = numberPage;
        }

        class Library
        {
            private List<Book> books;

            public Library()
            {
                books = new List<Book>();
            }
            public void AddBook(Book book)
            {
                books.Add(book);
                Console.WriteLine("Livro adicionado com sucesso");
            }

            public void ListBook(Book book)
            {
                for (int i = 0; i < books.Count; i++)
                {
                    Console.WriteLine(books[i].BookName);
                }
            }

            public void FindBook(Book book)
            {

            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Library library = new Library();
                Book book1 = new Book("Fazendinha", "Cleiton Rosa", 50000);
                Book book2 = new Book("SatanC", "Satan", 666);
                library.AddBook(book1);
                library.AddBook(book2);
                library.ListBook(book1);
                library.ListBook(book2);
         

            }
        }
    }
}