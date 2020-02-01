using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace use_of_this
{
    class Person
    {
         private int age;
        private String name;
       private String location;
        public Person(string name,int age,string location)
        {
            this.age = age;
            this.name = name;
            this.location = location;
        }
        public void print()
        {
            Console.WriteLine("name : "+name +" age :"+age+" location "+location);
        }
    }
    class Use_of_this
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("abhinav",18,"bangalore");
            Person p2 = new Person("amal", 10, "kerala");
            p1.print();
            p2.print();
            Console.ReadKey();



        }
    }
}
