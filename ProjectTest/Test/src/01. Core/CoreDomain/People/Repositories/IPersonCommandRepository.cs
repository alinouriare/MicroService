using CoreDomain.People.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Zamin.Core.Domain.TacticalPatterns;

namespace CoreDomain.People.Repositories
{
    public interface IPersonCommandRepository
    {
        public void Add(Person person);
        public Person Get(BusinessId id);
    }
}
