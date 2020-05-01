using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pulsar.Client.Api;

namespace firstapp
{
    class message
    {
        public static async Task startpulsar()
        {
            Console.WriteLine("enterred");
            const string serviceurl = "pulsar://localhost:30002";
            const string subname = "mysub";
            var topicname = $"mytopic";

            var client = new PulsarClientBuilder().ServiceUrl(serviceurl)
                .Build();

            var producer = await new ProducerBuilder(client)
                .Topic(topicname)
                .CreateAsync();

            var consumer = await new ConsumerBuilder(client)
                .Topic(topicname)
                .SubscriptionName(subname)
                .SubscribeAsync();

            var messageid = await producer.SendAsync(Encoding.UTF8.GetBytes($"send from abhi at '{DateTime.Now}'"));
            Console.WriteLine($"message '{messageid}'");

            var message = await consumer.ReceiveAsync();
            Console.WriteLine($"received : {Encoding.UTF8.GetString(message.Data)}");

            await consumer.AcknowledgeAsync(message.MessageId);
        }

    }
}
