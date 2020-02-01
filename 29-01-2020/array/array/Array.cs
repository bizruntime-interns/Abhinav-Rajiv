using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_01_2020
{
    class Array
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1D array size");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("enter the elements");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The elements are");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                

            }
            Console.ReadKey();
        }
    }
}
