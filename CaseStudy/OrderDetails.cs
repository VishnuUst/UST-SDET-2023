using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class OrderDetails:Customer
    {
        public OrderDetails(int productId,int customerId,string?status, string? customerName, string? email,string?type) : base(customerId, customerName, email)
        {
           
            ProductId = productId;
            CustomerId = customerId;
            Status = status;
            Type = type;
        }

        
        public int ProductId { get; set; }
        public int CustomerId {  get; set; }
        public string? Status { get; set; }
        public string? Type {  get; set; }
        public static List<OrderDetails> orderDetails = new List<OrderDetails>();

    }
}
