using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Pulsar.Client.Api;

namespace firstapp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            run();
           
            // await TlsAuthentication.RunTlsAuthentication();
            // await CustomProps.RunCustomProps();
            // await ReaderApi.RunReader();
            // await RealWorld.RunRealWorld(PulsarClient.Logger);

            Console.WriteLine("Example ended. Press any key to exit");
            
            Console.ReadKey();


        }
        public static async void run()
        {
            await message.startpulsar();
        }
    }
}
