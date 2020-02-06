using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;

namespace videoecoder
{
    public class Videoencoder
    {
        public delegate void Videoencode(object obj, EventArgs args);
        public Videoencode OnvideoEncoded;
        public void Encode()
        {
            Console.WriteLine("VIDEO IS ENCODING");
            Thread.Sleep(1000);
            OnEncoded();
        }
        protected virtual void  OnEncoded()
        {
            if(OnvideoEncoded!=null)
            {
                OnvideoEncoded(this, EventArgs.Empty);
            }
        }
    }
    class Message
    {
        public void messagesend(object obj,EventArgs args)
        {
            Console.WriteLine("message is send");
        }
    }
    class Video
    {
        static void Main(string[] args)
        {
            Videoencoder ve = new Videoencoder();
            Message mes = new Message();
            ve.OnvideoEncoded += mes.messagesend;
            ve.Encode();
            Console.ReadKey();

        }
    }
}
