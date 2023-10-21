using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Book
    {
        public Book(string? title, string? author, int iSBN, int price, string? availability)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            Price = price;
            Availability = availability;
        }
        

        public string? Title { get; set; }
        public string? Author { get; set; }
        public int ISBN {  get; set; }
        public int Price { get; set; }
        public string? Availability {  get; set; }

    }
}
