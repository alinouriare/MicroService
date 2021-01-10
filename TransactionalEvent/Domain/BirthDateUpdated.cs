using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
  public  class BirthDateUpdated:IDomainEvent
    {
        public Guid Id { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
