using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Eventargs
{
    class Events
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {          
             Counter c = new Counter();
            c.ThresholdReached += C_ThresholdReached;
            log.Debug("enter a");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                log.Info("enter again");
                c.Count();
            }
            Console.ReadKey();
        }

        private static void C_ThresholdReached(object sender, Thresholdevent e)
        {
            log.Info("the count has been exeeded " + e.count);           
        }
    }
    class Counter
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public delegate void counted(object obj,EventArgs args);

        int count = 0;
        public void Count()
        {
            count++;
            log.Info(count);
            if(count>5)
            {
                Thresholdevent theve = new Thresholdevent();
                theve.count = count;
                theve.date = DateTime.Now;
                OnThresholdReached(theve);
            }
        }

        protected virtual void OnThresholdReached(Thresholdevent e)
        {
            EventHandler<Thresholdevent> handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler<Thresholdevent> ThresholdReached;
    }
    class Thresholdevent : EventArgs
    {
        public int count { get; set; }
        public DateTime date { get; set; }
    }

}
    

