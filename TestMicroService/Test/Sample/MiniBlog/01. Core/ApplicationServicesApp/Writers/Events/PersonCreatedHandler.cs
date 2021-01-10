using ApplicationServices.Events;
using CoreDomainApp.Writer.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServicesApp.Writers.Events
{
    public class PersonCreatedHandler : IDomainEventHandler<PersonCreated>
    {
        public Task Handle(PersonCreated Event)
        {
            Console.WriteLine(Event.FirstName);
            return Task.CompletedTask;
        }
    }

    public class PersonUpdatedHandler : IDomainEventHandler<PersonUpdated>
    {
        public Task Handle(PersonUpdated Event)
        {
            Console.WriteLine(Event.FirstName);
            return Task.CompletedTask;
        }
    }
}
