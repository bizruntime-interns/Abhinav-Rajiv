using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace delegatesex3
{

    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public delegate void message(string a);
        public static void printa(String a)
        {
            log.Info("string a" + a);
        }
        public static void printb(string b)
        {
            log.Info("string b" + b);
        }
        public static void print(message ms)
        {
            log.Info("print function");
            ms("hello");
        }
        static void Main(string[] args)
        {
            message m1 = new message(printa);
            message m2 = new message(printb);
            print(m1);
            print(m2);
            Console.ReadKey();

        }
    }
}
