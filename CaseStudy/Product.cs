using CaseStudy.MyExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CaseStudy.MyExceptions.MyProductException;

namespace CaseStudy
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public double Price { get; set; }
        public int ProductQuantity { get; set; }

        public static void AddProduct(DigitalProduct product)
        {
            if(product.ProductId<=0)
            {
                throw new UserException(MyProductException.exMessageList["One"]);
            }
            if(string.IsNullOrEmpty(product.ProductName))
            {
                throw new UserException(MyProductException.exMessageList["Five"]);
            }
        }

        

    }
}