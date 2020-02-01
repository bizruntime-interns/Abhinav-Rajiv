using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @struct
{
    struct Rectangle
    {
        public int height, weight;
        public Rectangle(int h,int w)
        {
            this.height = h;
            this.weight = w;
        }
        public void area()
        {
            Console.WriteLine("area is " + height * weight);
        }
    }
    class Struct
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 20);
            r.area();
            Rectangle r2 = new Rectangle(30, 40);
            r2.area();
            Console.ReadKey();

        }
    }
}
