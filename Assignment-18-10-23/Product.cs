using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_18_10_23
{
    internal class Product
    {
        private string? productname;
        private int price,quantity;

        public Product(string? productname, int price, int quantity)
        {
           Productname = productname;
           Price = price;
            Quantity = quantity;
        }

        public string? Productname { get => productname; set => productname = value; }
        public int Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public void Setprice()
        {
            double newprice=Price;

        }
        public double ProductValue()
        {
            double totalvalue = Price * Quantity;
            return totalvalue;
        }

    }
}
