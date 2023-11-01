using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignments
{
    internal class TourismDestinationOne
    {
        public TourismDestinationOne(string? name, string? location, double rating, double price)
        {
            Name = name;
            Location = location;
            Rating = rating;
            Price = price;
        }

        public string ? Name { get; set; }
        public string ? Location { get; set; }
        public double Rating {  get; set; }
        public double Price { get; set; }

        public static List<TourismDestinationOne> tourismDestinationOnes = new List<TourismDestinationOne>();


        public static void TopRated(double rate)
        {
            var data  = tourismDestinationOnes.FindAll(x=>x.Rating > rate);
            if(data != null)
            {
                Console.WriteLine("**Top Rated Place**");
                foreach (var x in data)
                {
                    Console.WriteLine($"Place Name:{x.Name}\tLocation:{x.Location}" +
                        $"\tRating:{x.Rating}\tPrice:{x.Price}");
                }
            }
            else
            {
                Console.WriteLine("No record found");
            }
               
                
        }

        public static void ViewDataPricePerNight()
        {
            var dataone = tourismDestinationOnes.OrderBy(y=>y.Price);
           if(dataone != null)
            {
                Console.WriteLine("**Price Affordable Places**");
                foreach (var x in dataone)
                {
                    Console.WriteLine($"Place Name:{x.Name}\tLocation:{x.Location}" +
                        $"\tRating:{x.Rating}\tPrice:{x.Price}");
                }
            }
            else
            {
                Console.WriteLine("No record found");
            }

        }
        
        public static void  FilterPlaceByCityOrRegion(string?place)
        {
            var dataTwO = tourismDestinationOnes.FindAll(d => d.Location == place);
            if(dataTwO != null)
            {
                Console.WriteLine("***Place According To Particular Location***");
                foreach(var x in dataTwO)
                {
                    Console.WriteLine($"Place Name:{x.Name}\tLocation:{x.Location}" +
                       $"\tRating:{x.Rating}\tPrice:{x.Price}");

                }
            }
            else
            {
                Console.WriteLine("No Record Found");
            }
        }

    }
}
