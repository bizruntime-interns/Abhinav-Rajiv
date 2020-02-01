using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace two_threads
{
    class Mythread
    {
        public void Mythread1()
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine(i+" name :"+Thread.CurrentThread.Name); 
            }
        }
        public void mythread2()
        {
            for(int j=0;j<4;j++)
            {
                Console.WriteLine("this lines will execute respectively");
            }
        }
    }

    class Multi
    {
        static void Main(string[] args)
        {
            Multi mt = new Multi();
            mt.createthread();
        }
        public void  createthread()
        {
            Mythread mt = new Mythread();
            Thread thread4 = new Thread(new ThreadStart(mt.Mythread1));
            Thread thread1 = new Thread(new ThreadStart(mt.Mythread1));
            Thread thread2 = new Thread(new ThreadStart(mt.Mythread1));
            Thread thread3 = new Thread(new ThreadStart(mt.mythread2));
            Console.WriteLine("thread joining example");
            thread1.Name = "first";
            thread2.Name = "second";
            thread4.Name = "Prior thread";
            thread4.Priority = ThreadPriority.Highest;
            thread4.Start();
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread3.Join();

            Console.ReadKey();


        }
    }
}
