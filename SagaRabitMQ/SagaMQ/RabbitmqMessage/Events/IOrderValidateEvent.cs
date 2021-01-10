using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitmqMessage.Events
{
    public interface IOrderValidateEvent
    {
        public Guid OrderId { get; }
        public string PaymentCardNumber { get; }
        public string ProductName { get; }
    }
}
