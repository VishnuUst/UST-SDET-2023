using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Generic
    {
        public void ListHandling()
        {
            List<int> list = new List<int> ();
            list.Add (2);
            list.Add (1);
            list.Add (3);
            Console.WriteLine("List data");
            foreach (int i in list)
            {
                Console.WriteLine (i);
            }
            list.Sort();
            Console.WriteLine("Sorted List IS");
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            list.Remove(2);
            Console.WriteLine("Removed successfully .Available data is:");
            foreach (int item in list)
            {
                Console.WriteLine(item);

            }
            
        }
        public void DictionaryHandling()
        {
          Dictionary<int,string> dictionary = new Dictionary<int,string> ();
            dictionary.Add(1, "Hari");
            dictionary.Add(2, "Joby");
            dictionary.Add(3, "Vimal");
            Console.WriteLine("Dictionary Data");
            foreach(var item in dictionary)
            {
                Console.WriteLine(item);
            }
            dictionary.Remove(3);
            Console.WriteLine("Removed Successs.Show the Valued Data");
            foreach(var item in dictionary.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Data showed in KeyValue");
            foreach(var item in dictionary.Keys)
            {
                Console.WriteLine(item);
            }

        }
        public void StackHandling()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine("Stack Data");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Pop success:{ stack.Pop()}");
            Console.WriteLine("POP After");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Peek Data Is:{stack.Peek()}");
            Console.WriteLine("Data showed after peek");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
        public void QueueHandling()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine("queue Data");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Dequeue success:{queue.Dequeue()}");
            Console.WriteLine("Dequeue After");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Peek Data IS:{queue.Peek()}");
            Console.WriteLine("Data showed after peek");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
