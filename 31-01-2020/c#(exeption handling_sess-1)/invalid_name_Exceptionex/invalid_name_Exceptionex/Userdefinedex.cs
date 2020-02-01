using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invalid_name_Exceptionex
{
    class InvalidNameException:Exception
    {
        public InvalidNameException(string message) : base(message)
        { }      
    }
    

    class Userdefinedex
    {
        static void Validate(string name)
        {
            if (name.Length < 3)
            {
                throw new InvalidNameException("name is not complete");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name");
            String name = Console.ReadLine();
            try
            {
                Validate(name);
            }catch(InvalidNameException e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
