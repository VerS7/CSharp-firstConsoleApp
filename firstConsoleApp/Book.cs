using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstConsoleApp
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }
        public void Print() 
        {
            Console.WriteLine(Title);
            Console.WriteLine(Author);
            Console.WriteLine(Price);
        }
    }
    public class BookGenre : Book 
    {
        public string Genre { get; set; }
        public BookGenre(string genre, string title, string author, double price) : base(title, author, price)    
        {
            Genre = genre;
        }
        public new void Print() 
        {
            Console.WriteLine(Title);
            Console.WriteLine(Author);
            Console.WriteLine(Genre);
            Console.WriteLine(Price);
        }
    }
    public class BookGenrePubl : BookGenre
    {
        public string Publisher { get; set; }
        public BookGenrePubl(string genre, string title, string author, double price, string publisher) : base(genre, title, author, price) 
        {
            Publisher = publisher;
        }
        public new void Print()
        {
            Console.WriteLine(Title);
            Console.WriteLine(Author);
            Console.WriteLine(Genre);
            Console.WriteLine(Price);
            Console.WriteLine(Publisher);
        }
    }
}
