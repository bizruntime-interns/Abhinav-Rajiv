using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apache.Ignite.Core;
using Apache.Ignite.Core.Binary;
using Apache.Ignite.Core.Cache;
using Apache.Ignite.Core.Cache.Configuration;
using Apache.Ignite.Core.Configuration;

namespace adodotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ignite = Ignition.StartFromApplicationConfiguration())
            {
                var cacheconfig = new CacheConfiguration
                {
                    Name = "student",
                    CacheStoreFactory = new studentfactory(),
                    KeepBinaryInStore=true,
                    ReadThrough=true,
                    WriteThrough=true
                };
                ICache<int, IBinaryObject> student = ignite.GetOrCreateCache<int, object>(cacheconfig).WithKeepBinary<int, IBinaryObject>();

                IBinaryObject stud = ignite.GetBinary()
                    .GetBuilder("student")
                    .SetStringField("name", "ignite abhi")
                    .SetStringField("city", "muz")
                    .SetIntField("salary", 20000)
                    .SetStringField("location", "kannur")
                    .Build();
                Console.WriteLine("putting to cache");
              //  student.Put(101, stud);
                Console.WriteLine("puted to cache");
                Console.WriteLine("reading from cache");
                IBinaryObject students = student.Get(1);
                Console.WriteLine("value from cache " + students.GetField<string>("name"));
                Console.ReadKey();

            }
        }
    }
}
