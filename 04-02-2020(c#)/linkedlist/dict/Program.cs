using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace dict
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
                LinkedList<String> names = new LinkedList<String>();
                names.AddLast("abhi");
                names.AddLast("amal");
                names.AddLast("rajiv");
                names.AddLast("sujina");
                names.AddLast("leela");
                names.AddLast("raghavan");
                Console.WriteLine("he list is");
                foreach (string str in names)
                {
                    Console.WriteLine(str);
                }
                names.Remove(names.First);

                foreach (string str in names)
                {
                    Console.WriteLine(str);
                }


                Console.WriteLine("removing abhi");

                names.Remove("abhi");

                foreach (string str in names)
                {
                    Console.WriteLine(str);
                }


                Console.WriteLine("Removing the first ");

                names.RemoveFirst();

                foreach (string str in names)
                {
                    Console.WriteLine(str);
                }


                Console.WriteLine("removing last one");

                names.RemoveLast();

                foreach (string str in names)
                {
                    Console.WriteLine(str);
                }


                names.Clear();
                Console.WriteLine("Number of people: {0}",
                                             names.Count);

            }
        }

    }


