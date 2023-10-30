using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class GenericsExample<T>
    {
        private T value1, value2;
        private T[] values;

      

        public GenericsExample(T[] values)
        {
           
            Values = values;
        }

        public T Value1 { get { return value1; } set { value1 = value; } }
        public T Value2 { get { return value2; } set { value2 = value; } }
        public T[] Values { get { return values; } set { values = value; } }
        public void Display()
        {
            foreach (var item in Values)
            {
                Console.WriteLine(item);
            }
        }

    }
}
