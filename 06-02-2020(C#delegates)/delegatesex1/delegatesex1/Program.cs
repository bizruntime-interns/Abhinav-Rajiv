using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]

delegate int operations(int n);
namespace delegatesex1
{
    delegate int operations(int n);
    class Deleegates
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static int num = 10;
        public static int Add(int a)
        {
            num += a;
            return num;
        }
        public static int mul(int b)
        {
            num += b;
            return num;
        }
        public static int getnum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            operations op = new operations(Add);
            operations op2 = new operations(mul);
            op(10);
            log.Info("num is " + getnum());
            op2(20);
            log.Info("num is " + getnum());
            Console.ReadKey();



        }
    }
}
