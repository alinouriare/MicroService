using System;
using System.Collections.Generic;
using System.Text;

namespace Framework
{
   public class AggregateRoot:Entity
    {
        public int Version { get;private set; }

        private readonly List<IDomainEvent> _domainEvents = new List<IDomainEvent>();

        protected AggregateRoot() { }

        protected void AddDomainEvent(IDomainEvent @event) =>
            _domainEvents.Add(@event);

        protected void RemoveDomainEvent(IDomainEvent @event) =>
            _domainEvents.Remove(@event);

        public IReadOnlyCollection<IDomainEvent> DomainEvents =>
          _domainEvents.AsReadOnly();

        public AggregateRoot(IEnumerable<IDomainEvent> events)
        {
            if (events == null) return;
            foreach (var domainEvent in events)
            {
                Mutate(domainEvent);
                Version++;

            }
        }
        protected void Apply(IEnumerable<IDomainEvent> events)
        {
            foreach (var @event in events)
            {
                Apply(@event);
            }
        }

        protected void Apply(IDomainEvent @event)
        {
            Mutate(@event);
            AddDomainEvent(@event);
        }
        private void Mutate(IDomainEvent @event) =>
       ((dynamic)this).On((dynamic)@event);
    }
}
