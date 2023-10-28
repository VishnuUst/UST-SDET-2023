using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Product
    {
       
        public static List<Product> products = new List<Product>();

        public int ProductId { get; set; }
        public static string? ProductType {  get; set; }
        public string? ProductName { get; set; }
        public int Price { get; set; }  
        public int StockQuantity {  get; set; }
        
    }
}
