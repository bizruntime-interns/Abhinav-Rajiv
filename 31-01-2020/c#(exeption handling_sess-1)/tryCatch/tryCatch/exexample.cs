using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch
{
    class exexample
    {
        static void Main(string[] args)
        {
            try
            {   int x = 10;
                int y = 0;
                int z = x / y;
                Console.WriteLine("output" + z);
            }
            catch (Exception E)
            {
                Console.WriteLine(E);
            }
            Console.ReadKey();
        }
    }
}
