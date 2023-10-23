using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Circle :Shape,IDrawable
    {
        const double PI= 3.14;

        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius { get; set; }

        public override double CalculateArea()
        {
            return  PI* Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * PI * Radius;
        }
        public void Draw()
        {
            Console.WriteLine($"Area Of Circle is:{CalculateArea()}");
            Console.WriteLine($"Perimeter Of Cirlce Is:{CalculatePerimeter()}");

        }

    }
}
