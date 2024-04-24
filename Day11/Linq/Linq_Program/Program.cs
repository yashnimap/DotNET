using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Program
{
    public class Books
    {
        public string Title { get; set; }
        public float price { get; set; }
    }

    public class Repository
    {
        public IEnumerable<Books> GetBooks()
        {
            return new List<Books>
            {
                new Books() { Title = "java", price = 1 },
                new Books() { Title = "python", price = 5 },
                new Books() { Title = "c#", price = 8 }
            };
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                var books = new Repository().GetBooks();
                //Linq query operators
                var a = from b in books 
                        where b.price >= 1 
                        select b;


                //Linq extension method
                var checkBooks = books
                                      .Where(b => b.price < 6)
                                      .OrderBy(b=> b.price);

                foreach (var book in checkBooks)
                {
                    Console.WriteLine(book.Title + " " + book.price);
                }
            }
        }
    }
}
