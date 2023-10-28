using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class PhysicalProduct : Product, IOrderable
    {
        public double Weight { get; set; }
        public string? Dimension { get; set; }

        public static List<PhysicalProduct> Products = new List<PhysicalProduct>();

        public void DeliveringProduct()
        {
            Console.WriteLine("product is shipped Successfully and shipping cost is {0}", Weight * 10);
        }

        public void PlacingOrder()
        {
            Console.WriteLine("Do you want to continue Press\n1. for yes\n2. for No");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                if (ProductQuantity > 0)
                    Console.WriteLine("Continue to payment");
                else
                    Console.WriteLine("product not available");
            }
            else
            {
                Console.WriteLine("Product Is reverting");
            }

        }

        public void ProcessingPayment()
        {
            Console.WriteLine("Enter the card details for product {0}", ProductName);
            string? crednum = Console.ReadLine();
            if (crednum == null)
            {
                Console.WriteLine("invalid number");
            }
            else
            {
                Console.WriteLine("payment successful");
            }
        }
    }
}