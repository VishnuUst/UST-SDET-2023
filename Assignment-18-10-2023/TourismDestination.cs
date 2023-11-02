using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oct19_Q1
{
    internal class TourismDestination
    {
        public TourismDestination(string? name, string? country, double? rating)
        {
            Name = name;
            Country = country;
            Rating = rating;
        }

        public string? Name { get; set; }
        public string? Country { get; set; }
        public double? Rating { get; set; }

        public void SortListOfTour(List<TourismDestination> list)
        {
            var sortedList = list.OrderByDescending(x => x.Rating);
            foreach (TourismDestination item in sortedList)
            {
                Console.WriteLine("Name:{0}\tCountry:{1}\tRating:{2}", item.Name, item.Country, item.Rating);
            }
        }
    }
}