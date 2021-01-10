using Dal;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EventPublisher
{
    class Program
    {
        public static async Task Main()
        {
            var bus = Bus.Factory.CreateUsingRabbitMq(sbc=> {

                sbc.Host("rabbitmq://localhost");
                sbc.ReceiveEndpoint("person_queue", ep =>
                {

                });
            });

            var opb = new DbContextOptionsBuilder<PersonDB>();

            opb.UseSqlServer("Server =.; Database=PersonDb ; Integrated Security = true; MultipleActiveResultSets=true");

            var context = new PersonDB(opb.Options);
            await bus.StartAsync(); // This is important!
            do
            {
                var events = context.OutBoxEvents.ToList();
                foreach (var outboxEvent in events)
                {
                    await bus.Publish(outboxEvent);
                    context.Remove(outboxEvent);
                    context.SaveChanges();
                }

                System.Threading.Thread.Sleep(2000);
            } while (true);




            await bus.StopAsync();
        }
    }
}
