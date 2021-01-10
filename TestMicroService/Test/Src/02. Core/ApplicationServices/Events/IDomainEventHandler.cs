using CoreDomain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Events
{
    public interface IDomainEventHandler<TDomainEvent>
         where TDomainEvent : IDomainEvent
    {
        Task Handle(TDomainEvent Event);
    }
}
