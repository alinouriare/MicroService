using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Events.Orders
{
  public  class OrderAddEvent:INotification
    {
        public OrderAddEvent(int userId)
        {
            UserId = userId;
        }

        public int UserId { get; set; }
    }
}
