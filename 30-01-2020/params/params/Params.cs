using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @params
{

    class Params
    {
        static void Main(string[] args)
        {
            show("abhi",1,3,"amal","rajiv","sujina");
        }
        private static void show(params object[] arr)

        {
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
