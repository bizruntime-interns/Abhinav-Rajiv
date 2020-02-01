using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkedex
{
    class checked_example
    {
        static void Main(string[] args)
        {
            checked
            {
                int i = int.MaxValue;
                try
                {
                    Console.WriteLine(i + 3);
                }catch(Exception e)
                {
                    Console.WriteLine(e);
                }
             }


            unchecked
            {
                try
                {
                    int i = int.MaxValue;
                    Console.WriteLine("\n using unchecked keyword"+i + 3);
                }catch(Exception E)
                {
                    Console.WriteLine(E);
                }
            }
            Console.ReadKey();


            
        }
    }
}
