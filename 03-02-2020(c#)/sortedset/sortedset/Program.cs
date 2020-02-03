using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashset
{
    class SortedsetExample
    {
        static void Main(string[] args)
        {
            SortedSet<String> sort = new SortedSet<String>();
            Add(sort);
            Get(sort);
            Console.ReadKey();

        }
        static void Add(SortedSet<String> hash)
        {
            Console.WriteLine("enter the n.o of items");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the elements");
            for (int i = 0; i < n; i++)
            {
                hash.Add(Console.ReadLine());
            }
        }
        static void Get(SortedSet<string> hash)
        {
            Console.WriteLine("the elements in sortedset are");
            foreach (var i in hash)
            {
                Console.WriteLine(i);
            }
        }
    }
}
