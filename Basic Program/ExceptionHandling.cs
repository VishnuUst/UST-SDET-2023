using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class ExceptionHandling
    {
        public ExceptionHandling(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public void Divide()
        {
            try
            {
                int[] num = { 10, 20, 30 };
                int res = Num1 / Num2;
               
                Console.WriteLine(res);
                foreach (int num2 in num)
                {
                    res = num2 / Num2;
                    Console.WriteLine(res);
                }
            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Source);
                Console.WriteLine("Divide By Zero Is Not Possible");
            }
        }

    }
}
