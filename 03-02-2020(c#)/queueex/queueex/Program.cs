using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queueex
{
    class QueueExample
    {
        static void Main(string[] args)
        {
            Queue<string> st = new Queue<string>();
            Add(st);
            Get(st);
            Popex(st);
            Console.ReadKey();
        }
        static void Add(Queue<string> st)
        {
            Console.WriteLine("enter the n.o of elemnts to enqueue in queue");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                st.Enqueue(Console.ReadLine());
            }

        }
        static void Get(Queue<string> st)
        {
            Console.WriteLine("\nThe elements in queue are");
            foreach (string i in st)
            {
                Console.WriteLine(i);
            }
        }
        static void Popex(Queue<string> st)
        {
            Console.WriteLine("\n dequeue an element");
            Console.WriteLine("dequeue:" + st.Dequeue());
            Console.WriteLine("peek element:" + st.Peek());
            Get(st);
        }
    }
}
