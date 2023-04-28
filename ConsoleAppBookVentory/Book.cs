using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBookVentory
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }


        public override string ToString()
        {
            return $"Title: {Title}\nAuthor: {Author}\nPrice: {Price:C}\nQuantity in stock: {StockQuantity} pieces";
        }
    }
}
