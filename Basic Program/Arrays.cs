using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Arrays
    {
        int[] numbers =new int[5];
        int[,] nums = { { 1, 2, 3},{ 5, 6, 7 } };
        public void OneDimensional()
        {
            numbers[0] = 2;
            numbers[1] = 1;
            numbers[2] = 300;

            Array.Sort(numbers);
            Console.WriteLine("One Dimensional Array sort");
            for (int i=0;i<numbers.Length;i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("One Dimensional Array Clear the Second array elements");
            Array.Clear(numbers);
           foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        public void TwoDimensional()
        {
            

             Console.WriteLine("Two Dimensional Array");
            foreach (var number in nums)
            {
                Console.WriteLine(number);
            }

        }
    }
}
