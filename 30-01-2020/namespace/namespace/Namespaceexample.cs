using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace first
{
    class Animal
    {
       public void sound()
        {
            Console.WriteLine("from first namespace");
        }
    }

}
namespace second
{
    class Dog
    {
        public void sound()
        {
            Console.WriteLine("this is from second namespace");
        }
    }
}
namespace @namespace
{
    class Namespaceexample
    {
        static void Main(string[] args)
        {
            first.Animal a = new first.Animal();
            second.Dog d = new second.Dog();
            a.sound();
            d.sound();
            Console.ReadKey();
        }
    }
}
