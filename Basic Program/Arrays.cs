using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Arrays
    {
        int[] numbers = new int[5];
        int[,] nums = { { 1, 2, 3 }, { 5, 6, 7 } };
        public void OneDimensional()
        {
            numbers[0] = 2;
            numbers[1] = 1;
            numbers[2] = 300;

            Array.Sort(numbers);
            Console.WriteLine("One Dimensional Array sort");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("One Dimensional Array Clear the Second array elements");
            Array.Clear(numbers);
            foreach (var number in numbers)
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
        public void Jaggerdarray()
        {
            int[][,] arr = new int[][,]
            {
                new int[,] { { 1, 2 }, { 3,4 } },
                new int[,] { { 100, 200 }, { 300, 400 }, { 1000,4000} }
            };
            Console.WriteLine("Jaggered Array Elements:");
            for(int i=0; i<arr.Length; i++)
            {
                int x = 0;
                for(int j = 0; j < arr[i].GetLength(x);j++)
                {
                    for(int k = 0; k < arr[j].Rank; k++)
                    {
                        Console.WriteLine(arr[i][j,k] + " ");
                    }
                    Console.WriteLine();
                }
                x++;
                Console.WriteLine();
            }
        }
    }
}

