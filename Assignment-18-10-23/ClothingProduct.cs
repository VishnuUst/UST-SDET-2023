using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_18_10_23
{
    internal class ClothingProduct : Product
    {
        string? size;
        public ClothingProduct(string? productname,string?size, int price, int quantity) : base(productname, price, quantity)
        {
            this.size = size;
        }
        public void DisplayClothingProductSize()
        {
            Console.WriteLine($"Size Of The Product:{size}");
        }
    }
}
