using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate int operations(int n);
namespace multicast_dele
{
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
            operations op;
            operations op1 = new operations(Add);
            operations op2 = new operations(mul);
            op = op1;
            op += op2;
            op(20);
            Console.WriteLine(getnum());
            int outt = getnum();
            log.Error("num is ");
            Console.ReadKey();



        }
    }
}
