using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @finally
{
    class Finallyex
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 10;
                string y=null;
                int z = x /int.Parse(y);
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("finally code ");
            }
            Console.ReadKey();


        }
    }
}
