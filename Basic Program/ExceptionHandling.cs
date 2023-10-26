using Basic_Program.ExceptionMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Basic_Program.ExceptionMessage.MyException;

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
            int[] num = { 10, 20, 30 };
            int res = Num1 / Num2;

            Console.WriteLine(res);
        }
        public void NumCheck()
        {
            if (Num1 >= 100)
            {
                Console.WriteLine("Congraz");
            }
            else
            {
                throw new Num1Exception(MyException.exMessageList["Three"]);
            }
        }
        public void NumcheckOne()
        { 
            if(Num2<100) 
            {
               
                Console.WriteLine("Congrazzz");
            }
            else
            {
                throw new Num2Exception(MyException.exMessageList["Four"]);
            }

        }
            
        

    }
}
