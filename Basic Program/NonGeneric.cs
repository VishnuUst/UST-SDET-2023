using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
           
            array.Add("UST");
            array.Add(true);
            array.Add(false);

            Console.WriteLine("Array Handling");
            foreach (var itemtwo in array)
            {
                Console.WriteLine(itemtwo);
            }

             array.Reverse();
            foreach (var itemtwo in array)
            {
                Console.WriteLine(itemtwo);
            }
            array.RemoveAt(7);
            foreach (var itemtwo in array)
            {
                Console.WriteLine(itemtwo);
            }
            array.Clear();
            foreach (var itemtwo in array)
            {
                Console.WriteLine(itemtwo);
            }
        }
        public void StackHandling()
        {
            Stack stack = new Stack();
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            stack.Push(10);
            Console.WriteLine("Stack Handling");
            foreach (var data in stack)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("Pop");
            Console.WriteLine(stack.Pop());
            foreach (var data in stack)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("Peek");
            Console.WriteLine(stack.Peek());//Show the last most element and cannot remove it
            foreach (var data in stack)
            {
                Console.WriteLine(data);
            }
                
        }
        public void QueueHandling()
        {
            Queue queue = new Queue();
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(10);
            Console.WriteLine("Queue Handling");
            foreach (var data in queue)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("Delete Queue Element");
            Console.WriteLine(queue.Dequeue());
            foreach (var data in queue)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("Peek");
            Console.WriteLine(queue.Peek());//Show the last most element and cannot remove it
            foreach (var data in queue)
            {
                Console.WriteLine(data);
            }

        }
        public void HashHandling()
        {
            Hashtable hash = new Hashtable();
            hash.Add(01, 1);
            hash.Add(02, 4);
            hash.Add(03, 6);
            Console.WriteLine("Hash Handling");
            foreach (var data in hash)
            {
                Console.WriteLine(data);
            }
            hash.Remove(01);
            Console.WriteLine("Remove Elements in hash table and display the available  keys");
            foreach (var data in hash.Keys)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("Remove Elements in hash table and display available the values");
            foreach (var data in hash.Values)
            {
                Console.WriteLine(data);
            }
            


        }
        public void SortedListHandling()
        {
            SortedList sortedList = new SortedList();
            sortedList.Add(02, 12);
            sortedList.Add(01, 13);
            sortedList.Add(03, 11);
            Console.WriteLine("SortedList Handling");
            foreach(var data in sortedList)
            {
                Console.WriteLine(data);
            }
            sortedList.RemoveAt(02);
            Console.WriteLine("RemovedSuccessfully and show available data values");
            foreach (var data in sortedList.Values)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("RemovedSuccessfully and show available Key values");
            foreach (var data in sortedList.Keys)
            {
                Console.WriteLine(data);
            }

        }
    }
}
