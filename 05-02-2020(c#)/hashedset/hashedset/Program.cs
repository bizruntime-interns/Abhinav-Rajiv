using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashedset
{
    class hashedset
    {
        static void Main(string[] args)
        {
            HashSet<int> hash = new HashSet<int>();
            for(int i=0;i<5; i++)
            {
                hash.Add(i);
            }
            if(hash.Contains(1))
            {
               
                Console.WriteLine("true");
            }
            HashSet<int> set3 = new HashSet<int>();
            for (int i = 0; i < 5; i++)
            {
               set3.Add(i);
            }
            Console.WriteLine(hash.Equals(set3));
            Console.ReadKey();
        }
    }
}
