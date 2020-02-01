using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace destructor
{
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Constructor Invoked");
        }
        ~Employee()
        {
            Console.WriteLine("Destructor Invoked");
        }
    }
    class Destruction
    {
        static void Main(string[] args)
        {
            deta();
            GC.Collect();

            

            Console.ReadKey();
        }
        public static void deta()
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
        }
    }
}
