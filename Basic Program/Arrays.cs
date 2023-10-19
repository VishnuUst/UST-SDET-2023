using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Arrays
    {
        readonly int[] numbers =new int[5];
        public void OneDimensional()
        {
            numbers[0] = 100;
            numbers[1] = 200;
            numbers[2] = 300;
            for(int i=0;i<numbers.Length;i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("Second array elements");
            
            for(int i=0;i<numbers.Length; i++)
            {
                numbers[1] = 123;
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
