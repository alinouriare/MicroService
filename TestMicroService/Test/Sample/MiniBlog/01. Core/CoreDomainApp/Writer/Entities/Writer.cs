using CoreDomain.Entities;
using CoreDomain.ValueObjects;
using CoreDomainApp.Writer.Events;
using CoreDomainToolkits.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDomainApp.Writer.Entities
{
   public class Writer: AggregateRoot
    {
        public Title FirstName { get; private set; }
        public Title LastName { get; private set; }

        public Writer(BusinessId businessId, Title firstName, Title lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            BusinessId = businessId;
            AddEvent(new PersonCreated
            {
                FirstName = FirstName.Value,
                LastName = LastName.Value,
                PersonId = BusinessId.Value.ToString()
            });
        }

        public void Update(Title firstName, Title lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            AddEvent(new PersonUpdated
            {
                FirstName = FirstName.Value,
                LastName = LastName.Value,
                PersonId = BusinessId.Value.ToString()
            });
        }
    }
}
