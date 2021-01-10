using CoreDomain.People.Entities;
using CoreDomain.People.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zamin.Core.Domain.TacticalPatterns;

namespace CommandSql.People
{
    public class PersonCommandRepository : IPersonCommandRepository
    {
        private readonly PersonDbContext dbContext;

        public PersonCommandRepository(PersonDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Add(Person person)
        {
            dbContext.People.Add(person);
            dbContext.SaveChanges();
        }

        public Person Get(BusinessId id)
        {
            return dbContext.People.FirstOrDefault(c => c.Id == id);
        }
    }

}
