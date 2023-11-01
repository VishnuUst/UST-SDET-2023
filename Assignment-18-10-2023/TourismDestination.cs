using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TourismDestination
    {
        public TourismDestination(string? name, string? country, double rating)
        {
            Name = name;
            Country = country;
            Rating = rating;
        }

        public string? Name { get; set; }
        public string? Country { get; set; }
        public double Rating { get; set; }
       public static List<TourismDestination> destinations = new List<TourismDestination>() ;
        public static void TourismDestinations()
        {
            Console.WriteLine("***Place Details By Rating in Descending Order***");
            Console.WriteLine("Place Name\tCountryName\tRating");
            var data = destinations.OrderByDescending(x => x.Rating).ThenByDescending(x => x.Name);
            foreach (var destination in data)
            {
                Console.WriteLine($"\t{destination.Name}\t\t{destination.Country}\t\t{destination.Rating}");
            }
           
        }

    }
}
