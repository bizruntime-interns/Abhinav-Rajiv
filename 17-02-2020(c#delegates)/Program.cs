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
            Thread.Sleep(3000);
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
            AudioEncoder audio = new AudioEncoder();

            ve.OnvideoEncoded += mes.messagesend;
            audio.Audioenc = mes.messagesend;

            ve.Encode();
            audio.AudioEncode();

            Console.ReadKey();
        }
    }

    class AudioEncoder
    {
        public delegate void AudioEncoded(object obj,EventArgs args);
        public AudioEncoded Audioenc;
        public void AudioEncode()
        {
            Console.WriteLine("Audio Encoding");
            Thread.Sleep(3000);
            onEncode();
        }
        public void onEncode()
        {
            Audioenc?.Invoke(this, EventArgs.Empty);
        }
    }
}
