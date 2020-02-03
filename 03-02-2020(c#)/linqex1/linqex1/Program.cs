using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqex1
{
    class Program
    {
        static void Main(string[] args)
        {
            List();
            Console.ReadKey();
        }
        static void List()
        {
            int[] arr = new int[] { 12, 98, 78, 65, 45, 100 };
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            IEnumerable<int> ienu = from ar in arr where ar> 20 select ar;
            Console.WriteLine("The n.o greater than 20 is ");
            foreach(int i in ienu)
            {
                Console.WriteLine(i);
            }
        }
    }
}
