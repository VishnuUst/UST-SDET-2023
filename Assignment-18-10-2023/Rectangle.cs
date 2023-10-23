using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Rectangle : Shape,IDrawable
    {
        public Rectangle(int length, int height)
        {
            Length = length;
            Height = height;
        }

        public int Length {  get; set; }
        public int Height { get; set; }
        public override double CalculateArea()
        {
            double area = Length * Height;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Length + Height;
            return perimeter;
        }
        public void Draw()
        {
            Console.WriteLine($"Area Of Rectangle is: {CalculateArea()}");
            Console.WriteLine($"Perimeter Of Rectangle is: {CalculatePerimeter()}");
        }
    }
}
