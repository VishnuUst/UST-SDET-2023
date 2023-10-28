using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Customers
    {
        public Customers(int customerId, string? customerName, string? customerEmail)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            CustomerEmail = customerEmail;
        }
        public static List<Customers> Customer = new List<Customers>();

        public int CustomerId {  get; set; }
        public string? CustomerName {  get; set; }
        public string? CustomerEmail { get; set;}

    }
}
