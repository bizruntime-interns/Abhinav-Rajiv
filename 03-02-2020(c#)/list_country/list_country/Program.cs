using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_country
{
    class country
    {
        public string state { get; set; }
        public string district { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<country> coun = new List<country>();
            coun.Add(new country { state = "kerala", district = "kannur" });
            coun.Add(new country { state = "kerala", district = "kasargod" });
            coun.Add(new country { state = "kerala", district = "wayanad" });
            coun.Add(new country { state = "kerala", district = "kozikode" });
            coun.Add(new country { state = "karnataka", district = "bagalore" });
            IEnumerable<country> query1 = from st in coun select st;
            foreach(country i in query1)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
