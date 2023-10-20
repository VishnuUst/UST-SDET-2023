using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal abstract class Vehicle
    {
        public int VehicleNumber { get; set; }
        public string? Brand {  get; set; }
        public string? Model {  get; set; }
        public string? Type {  get; set; }

        public abstract string? SetTypeForVehicle();
        public void Dipslay()
        {
            Console.WriteLine($"Vehicle Number :{VehicleNumber}\nBrand:{Brand}\nModel:{Model}");
        }



    }
}
