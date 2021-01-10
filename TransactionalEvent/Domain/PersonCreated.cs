using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
  public  class PersonCreated:IDomainEvent
    {

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
