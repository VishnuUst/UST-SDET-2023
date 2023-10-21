using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class BookType:Book
    {
        public string? Genre {  get; set; }
        public BookType(string? title, string? author, int isbn, int price, string? availability, string? genre) : base(title, author, isbn, price, availability)
        {
            this.Genre = genre;
        }
        
             
        public void DisplayDetails()
        {
            Console.WriteLine($"Book Title is:{Title}");
            Console.WriteLine($"Author Name is:{Author}");
            Console.WriteLine($"Isbn is:{ISBN}");
            Console.WriteLine($"Price Of Book Is:{Price}");
            Console.WriteLine($"Availability Of Bokk is:{Availability}");
            Console.WriteLine($"Book Type:{Genre}");
        }
    }
}
