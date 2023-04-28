using static System.Reflection.Metadata.BlobBuilder;

namespace ConsoleAppBookVentory
{
    public class Program
    {
        static void Main(string[] args)
        {
           IList<Book> books = new List<Book>()
           {
               new Book 
               {
                Title = "Awakenings",
                Author = "H.Olivia",
                Price = 10m, 
                StockQuantity= 1,
               },

               new Book
               {
                Title = "The Matarese Circle",
                Author = "R.Ludlum",
                Price = 16m,
                StockQuantity= 25,
               },

               new Book
               {
                Title = "Lord of the Rings",
                Author = "J.Tolkien",
                Price = 20m,
                StockQuantity= 15,
               },

               new Book
               {
                Title = "Ogboju ode ninu igbo irunmole",
                Author = "D.O. Fagunwa",
                Price = 21m,
                StockQuantity= 0,
               },

               new Book
               {
                Title = "The Bourne Supremacy",
                Author = "R.Ludlum",
                Price = 23m,
                StockQuantity= 7,
               },
           };
            
            ViewAllBooks(books);
            ViewBooksByAuthor(books, "R.Ludlum");
            ViewBooksByPrice(books, 10m, 20m);
            ViewOutOfStockBooks(books);
        }

        public static void ViewAllBooks(IList<Book> book)
        {
            Console.WriteLine("***All books in Collection***");
            Console.WriteLine();
            var allBooks = book.Where(book => book.Title != null && book.Author != null && book.Price != null && book.StockQuantity != null).ToList();

            foreach (var items in allBooks)
            {
               Console.WriteLine(items);
                Console.WriteLine();
            }
        }

       public static void ViewBooksByAuthor(IList<Book> book, string author)
       {
            Console.WriteLine();
            Console.WriteLine("****Books by Same Author****");
            Console.WriteLine();
            var allBooksByAuthor = book.Where(book => book.Author == author);
            foreach (var item in allBooksByAuthor)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }

        }

       public static void ViewBooksByPrice(IList<Book> book, decimal minprice, decimal maxprice)
       {
            Console.WriteLine($"***Books within the Range of the prices {minprice}-{maxprice}****");
            Console.WriteLine();
            var BooksWithinPriceRange = book.Where(book => book.Price > minprice && book.Price < maxprice);
            foreach (var item in BooksWithinPriceRange)
            {
                Console.WriteLine(item);
            }

        }

        public static  void ViewOutOfStockBooks(IList<Book> book)
        {
            Console.WriteLine();
            Console.WriteLine("***Books out of Stock***");
            Console.WriteLine();
            var BooksOutStock = book.Where(book => book.StockQuantity == 0);
            foreach (var item in BooksOutStock)
            {
                Console.WriteLine(item);
            }

        }
    }
}