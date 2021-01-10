using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitmqMessage.Events
{
    public interface IOrderStartedEvent
    {
        public Guid OrderId { get; set; }
        public string PaymentCardNumber { get; set; }
        public string ProductName { get; set; }
    }
}
