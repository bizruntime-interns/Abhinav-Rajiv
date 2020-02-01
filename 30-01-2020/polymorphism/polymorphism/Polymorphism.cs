using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    class Animal
    {
        public virtual void  sound ()
        {
            Console.WriteLine("aminal");
        }
    }
    class Cat : Animal
    {
        public override void sound()
        {
            Console.WriteLine("mew ");
        }
    }
    class Dog :Animal
    {
        public override void sound()
        {
            Console.WriteLine("bow");
        }
        public void anii()
        {
            base.sound();
        }
    }
    class Polymorphism
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            c.sound();
            Dog d = new Dog();
            d.sound();
            d.anii();
            Console.ReadKey();

        }
    }
}
