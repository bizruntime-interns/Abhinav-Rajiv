using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractionexample
{


    abstract class Animal
    {
        public abstract void animalsound();
        public void sound ()
        {
            Console.WriteLine("you are in an abstract class");
        }

    }
    class dog : Animal
    {
        public override void animalsound()
        {
            Console.WriteLine("sound of dog is bow");
        }
    }

    class Abstraction
    {
        static void Main(string[] args)
        {
            dog d = new dog();
            d.animalsound();
            d.sound();
            Console.ReadKey();

        }
    }
}
