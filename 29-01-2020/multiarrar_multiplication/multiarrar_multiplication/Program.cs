using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_01_2020
{
    class multiarray
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter the size of 2d array ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, m];
            Console.WriteLine("eneter elements");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());

                }

            }
            Console.WriteLine("enter the number you want to multiply with");
            int mul = int.Parse(Console.ReadLine());
            matmul(arr, mul);

        }
        static void matmul(int[,] arr,int mul)
        {
            for (int i = 0; i<arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = arr[i, j] * mul;

                }

            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]+" ");

                }
                Console.WriteLine("");


            }
            Console.ReadKey();
        }
    }
}
