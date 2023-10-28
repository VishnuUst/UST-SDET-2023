using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class DigitalProduct : Product, IOrderable
    {
        public string? DownloadLink { get; set; }
        public string? FileFormat { get; set; }

        public static List<DigitalProduct> Products = new List<DigitalProduct>();
        public void DeliveringProduct()
        {
            Console.WriteLine("Download link is {0}", DownloadLink);
        }

        public void PlacingOrder()
        {
            Console.WriteLine("Do you want to continue press \n 1 For Yes \n2 for No");
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
                Console.WriteLine("The Product data is reverting");
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