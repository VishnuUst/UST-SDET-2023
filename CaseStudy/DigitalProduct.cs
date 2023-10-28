using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class DigitalProduct:Product,IOrderable
    {
        

        public string? DownloadLink { get; set; }
        public string? FileFormat { get; set; }

        public void DeliveringProduct()
        {
            Console.WriteLine("Enter The Cutomer Id");
            int cuid =Convert.ToInt32(Console.ReadLine());
            OrderDetails order =OrderDetails.orderDetails.Find(x=>x.CustomerId == cuid);
            if (order == null)
            {
                Console.WriteLine("Order Not Found");

            }
            if(order.Status=="Active")
            {
                Console.WriteLine("Payment Not instantiated");
            }
            if(order.Status=="DeActive")
            {
                Console.WriteLine("Order Already Delivered");
            }
           
            else if(order.Status=="Pending")
            {
                Console.WriteLine("Tru Again Later!!!");
            }
            order.Status = "Completed";
            Console.WriteLine("Order Successfully finished!!!");
        }

        public  void PlacingOrder()
        {
            Console.WriteLine("Enter The Customer Id");
            int cuid = Convert.ToInt32(Console.ReadLine());
            var dataone = Customers.Customer.Find(x => x.CustomerId == cuid);
            if (dataone != null)
            {
                Console.WriteLine("Choose The Product Type Do you Want");
                string? type = Console.ReadLine();
                Console.WriteLine("Search The Product");
                string? name = Console.ReadLine();
                Console.WriteLine("Enter The Quantity");
                int qty = Convert.ToInt32(Console.ReadLine());

                var data = Product.products.Find(x => x.ProductName == name || x.StockQuantity <= qty);
                if (data != null)
                {

                    int id = Convert.ToInt32(Console.ReadLine());
                    OrderDetails orderDetail = new OrderDetails(data.ProductId, dataone.CustomerId, "Incomplete", dataone.CustomerName, dataone.CustomerEmail, type);
                    OrderDetails.orderDetails.Add(orderDetail);
                    Console.WriteLine("The Order success");
                }
                else
                {
                    Console.WriteLine("Prodcut Name is NoT Available Or Quantity is greater ");
                }

            }
            else
            {
                Console.WriteLine("Customer Not Available");
            }


        }



        public void ProcessingPayment()
        {
            throw new NotImplementedException();
        }
    }
}
