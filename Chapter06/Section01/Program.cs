using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4 };
            Console.WriteLine(numbers.Average());

            var books = Books.GetBooks();

            Console.WriteLine(books.Average(x => x.Price));
            Console.WriteLine(books.Sum(x => x.Pages));
            Console.WriteLine(books.Max(x => x.Price));

            var bookObj = books.Where(x => x.Title.Contains("物語")).OrderByDescending(x => x.Price);

            foreach (var book in bookObj) {
                Console.WriteLine("{0}:{1}円", book.Title, book.Price);
            }
            
            var bookObj2 = books.Where(x => x.Title.Contains("物語")).Average(x => x.Pages);
            Console.WriteLine(bookObj2);

            var longTitlrBooks = books.OrderByDescending(x => x.Title.Length);
            foreach (var book in longTitlrBooks) {
                Console.WriteLine("{0} {1}",book.Title,book.Price);
            }

        }
    }
}
