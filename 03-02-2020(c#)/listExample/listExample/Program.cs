using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listExample
{
    class Person
    {
        
        static void Main(string[] args)
        {
            List<String> l1 = new List<String>();
            ListCreate(l1);
            Allist(l1);
            Console.ReadKey();
        }
        public static void ListCreate(List<string> l1 )
        {
           

            Console.WriteLine("enter the n.o of elements ");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the elements");
            for(int i=0;i<num;i++)
            {
                l1.Add(Console.ReadLine());
            }
            Console.WriteLine("what element you want to search");
            int key=int.Parse(Console.ReadLine());
            Console.WriteLine(l1[key]);

        }
        public static void Allist(List<string> l1)
        {
            foreach(var name in l1)
            {
                Console.WriteLine(name);
            }
            
        }
    }
}
