using Domain.Events.Orders;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
  public  class Entity
    {
        public List<INotification> Events;

        public Entity()
        {
            Events = new List<INotification>();
        }

         public void AddDomainEvent(INotification @event)
        {
            Events.Add(@event);
        }

        public void ClearEvent()
        {
            Events.Clear();
        }
    }
}
