using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;


namespace userDefined_library
{
    class Program
    {
        static void Main(string[] args)
        {
            mathematics ac = new mathematics();
            int a = 10;
            int b = 20;
            Console.WriteLine(ac.addition(a, b));
            Console.ReadKey();
        }
    }
}
