using MassTransit;
using RabbitmqMessage.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stock
{
    public class OrderValidateConsumer :
      IConsumer<IOrderValidateEvent>
    {
        public async Task Consume(ConsumeContext<IOrderValidateEvent> context)
        {
            var data = context.Message;

            if (data.PaymentCardNumber.Contains("test"))
            {
                await context.Publish<IOrderCancelEvent>(
          new { OrderId = context.Message.OrderId, PaymentCardNumber = context.Message.PaymentCardNumber });
            }
            else
            {
                // send to next microservice
            }

        }
    }
}
