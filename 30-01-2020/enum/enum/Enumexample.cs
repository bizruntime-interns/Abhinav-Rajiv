using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    class Enumexample
    { public enum week {sunday,monday,tuesday,wednesday,thursday,friday,saturday}
        static void Main(string[] args)
        {
            week name_of_theday = (week)1;
            Console.WriteLine("name of the day 1 is " + name_of_theday);
            int x = (int)week.monday;
            Console.WriteLine("order of day "+week.monday+"is"+x);
            foreach (string a in Enum.GetNames(typeof(week)))
            {
                Console.WriteLine("week day :" + a);
            }
            
            Console.ReadKey();
        }
    }
}
