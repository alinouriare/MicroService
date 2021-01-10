using Contracts;
using MassTransit;
using System;
using System.Threading.Tasks;

namespace Client
{
   public class Program
    {
       public static async  Task Main(string[] args)
        {
            var bus = Bus.Factory.CreateUsingRabbitMq(sbc => { sbc.Host("rabbitmq://localhost"); });

            await bus.StartAsync();

            do
            {
                Console.WriteLine("Write your message ");
                var message = new Message
                {
                    Text = Console.ReadLine()
                };
                await bus.Publish(message);
                Console.WriteLine("Continue messaging? y/any thing else: ");
            } while (Console.ReadLine().ToLower() == "y");


            await bus.StopAsync();
        }
    }
}
