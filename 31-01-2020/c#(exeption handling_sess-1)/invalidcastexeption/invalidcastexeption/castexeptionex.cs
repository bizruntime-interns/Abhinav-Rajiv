using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invalidcastexeptionex
{
    class castexeptionex
    {
        static void Main(string[] args)
        {
            bool flag = true;
            try
            {
                char ch = Convert.ToChar(flag);
            }catch(InvalidCastException)
            {
                Console.WriteLine("boolean to char error");
            }
            try
            {
                IConvertible cha = flag;
                char chh = cha.ToChar(null);
            }catch(InvalidCastException)
            {
                Console.WriteLine("boolean to char error");
            }
            Console.ReadKey();
        }
    }
}
