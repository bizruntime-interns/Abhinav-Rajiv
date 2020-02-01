using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_01_2020
{
    class Switchex
    {
        public static void operation(int n1, int n2, char op)
        {
            int res = 0;
            switch (op)
            {
                case '*':
                    {
                        res = n1 * n2;
                        Console.WriteLine(res);
                        break;
                    }
                case '+':
                    {
                        res = n1 + n2;
                        Console.WriteLine(res);
                        break;
                    }
                case '/':
                    {
                        res = n1 / n2;
                        Console.WriteLine(res);
                        break;
                    }
                case '-':
                    {
                        res = n1 - n2;
                        Console.WriteLine(res);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("not valid");
                        break;
                    }

            }
        }
            static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1 st number");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the operation");
            char op = char.Parse(Console.ReadLine());
            operation(num, num2, op);
            Console.ReadKey();



        }
       
        
    }
}
