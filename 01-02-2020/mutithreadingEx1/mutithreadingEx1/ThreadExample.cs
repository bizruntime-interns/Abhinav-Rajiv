using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mutithreading
{
    class ThreadExample
    {
        static void Main(string[] args)
        {
            ThreadExample th = new ThreadExample();
            th.CreateThread();

        }
        private void CreateThread()
        {
            Thread maths = new Thread(mythread);
            maths.Name = "thread1";
            maths.Start();
            Console.WriteLine("main thread ends here");
            Console.ReadKey();

        }
        
        private void  mythread()
        {
            Console.WriteLine("status of the thred: "+Thread.CurrentThread.IsAlive);
            Console.WriteLine("name of the current thread is :" + Thread.CurrentThread.Name);
            Console.WriteLine("thread sleeps for 3 sec");
            Thread.Sleep(3000);
            Console.WriteLine("thread is back");
            Console.WriteLine("the state of the thread is : " + Thread.CurrentThread.ThreadState);
            Console.WriteLine("abort the thread");
            Thread.CurrentThread.Abort();



        }
    }
}
