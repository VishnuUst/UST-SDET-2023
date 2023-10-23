using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class ElectronicsProduct : Product
    {
        int warrantyperiod;
        public ElectronicsProduct(string? productname, int price, int quantity, int warrantyPeriod) : base(productname, price, quantity)
        {
        this.warrantyperiod=warrantyPeriod;

        }
        public void DisplayWarrantyPeriod()
        {
            Console.WriteLine($"Warranty Period is:{warrantyperiod}");
        }

    }
}
