using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackex
{
    class StackExample
    {
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();
            Add(st);
            Get(st);
            Popex(st);
            Console.ReadKey();
        }
        static void Add(Stack<string> st)
        {
            Console.WriteLine("enter the n.o of elemnts to push");
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                st.Push(Console.ReadLine());
            }

        }
        static void Get(Stack<string> st)
        {
            Console.WriteLine("\nThe elements in stack are");
            foreach(string i in st)
            {
                Console.WriteLine(i);
            }
        }
        static void Popex(Stack<string> st)
        {
            Console.WriteLine("\npoping an element");
            Console.WriteLine("pop:" + st.Pop());
            Console.WriteLine("peek element:" + st.Peek());
        }
    }
}
