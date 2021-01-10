using Contracts;
using MassTransit;
using System;
using System.Threading.Tasks;

namespace ServiceTest
{
   public class Program
    {
       public static async Task Main(string[] args)
        {

            var bus = Bus.Factory.CreateUsingRabbitMq(sbc =>
            {
                sbc.Host("rabbitmq://localhost");

                sbc.ReceiveEndpoint("test_queue", ep => {
                    ep.Handler<Message>(context => {
                        return Console.Out.WriteLineAsync($"Received: {context.Message.Text}");
                    });
                
                });
            });

            await bus.StartAsync();

            Console.WriteLine("Press any key to exit");
            await Task.Run(() => Console.ReadKey());

            await bus.StopAsync();
        }
    }
}
