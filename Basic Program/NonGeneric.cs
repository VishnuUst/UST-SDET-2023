using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class NonGeneric
    {
        public void ArrayList()
        {
            ArrayList array = new ArrayList();
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);
            array.Add(5);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
