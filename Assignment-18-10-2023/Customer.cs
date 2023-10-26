using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Customer
    {
        public int CustomerId { get; set; }
        public string ?CustomerName { get; set; }
        public int PhoneNumber { get; set; }

        public double Balance { get; set; }

        public static List<Customer> customer = new List<Customer>();

        public Customer(int customerId, string? customerName, int phoneNumber, double balance)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            PhoneNumber = phoneNumber;
            Balance = balance;
        }
        public  static void DisplayAllCustomer()
        {
            Console.WriteLine("***All CustomerDetails***");
            foreach (var customer in customer)
            {
                Console.WriteLine($"CustomerId:{customer.CustomerId}\nCustomerName:{customer.CustomerName}\nCustomerPhoneNumber:{customer.PhoneNumber}\nBalance:{customer.Balance}\n");
            }
        }
        public static void DisplayCustomerByPhoneNumber(int phonenumber)
        {
            Console.WriteLine("***Search By PhoneNumber***");
            var data = customer.Find(x => x.PhoneNumber == phonenumber);
            if(data!=null)
            {
                Console.WriteLine($"CustomerId:{data.CustomerId}\nCustomerName:{data.CustomerName}\nBalance:{data.Balance}\n");
                Console.WriteLine("***Thank You***");
            }
            else
            {
                Console.WriteLine("No Record Found.Try Again!!!");
            }

        }
    }
}
