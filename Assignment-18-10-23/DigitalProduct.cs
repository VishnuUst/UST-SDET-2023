using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class DigitalProduct : ElectronicsProduct
    {
        string? fileformat;

        public DigitalProduct(string? productname, string?fileformat,int price, int quantity, int warrantyPeriod) : base(productname, price, quantity, warrantyPeriod)
        {
            this.fileformat = fileformat;
        }
        public void DisplayFileFormat()
        {
            Console.WriteLine($"FileFormat is:{fileformat}\n");
        }
    }
}
