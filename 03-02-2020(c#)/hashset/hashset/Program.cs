using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashset
{
    class HashsetExample
    {
        static void Main(string[] args)
        {
            HashSet<String> hash = new HashSet<String>();
            Add(hash);
            Get(hash);
            Console.ReadKey();

        }
        static void Add(HashSet<String> hash)
        {
            Console.WriteLine("enter the n.o of items");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the elements");
            for(int i=0;i<n;i++)
            {
                hash.Add(Console.ReadLine());
            }
        }
        static void Get(HashSet<string> hash)
        {
            foreach(var i in hash)
            {
                Console.WriteLine(i);
            }
        }
    }
}
