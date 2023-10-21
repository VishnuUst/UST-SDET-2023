using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Order  
    {
       

       

        public Order(string? orderDate, int totalCost)
        {
            OrderDate = orderDate;
            TotalCost = totalCost;
            
        }

        public string? OrderDate {  get; set; }
        public int TotalCost { get; set; }
        

        public void DisplayOrder()
        {
            Console.WriteLine($"Order Date is :{OrderDate}");
            Console.WriteLine($"Total Cost Is:{TotalCost}");
        }
       
    }
}
