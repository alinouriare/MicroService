using CommandSql;
using CommandSql.People;
using CoreDomain.People.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationTests.ApplicationServices.People
{
   public class PersonCommandRepositoryFixture: IDisposable
    {

        public IPersonCommandRepository PersonCommandRepository { get; }
        public PersonDbContext DbContext { get; }

        public PersonCommandRepositoryFixture()
        {
            DbContextOptionsBuilder<PersonDbContext> optionsBuilder = new DbContextOptionsBuilder<PersonDbContext>();
            optionsBuilder.UseSqlServer("Server =.; Database=PersonDb ;Integrated Security=True;  MultipleActiveResultSets=true");
            DbContext = new PersonDbContext(optionsBuilder.Options);
            DbContext.Database.EnsureCreated();
            PersonCommandRepository = new PersonCommandRepository(DbContext);
        }

        public void Dispose()
        {
            DbContext.Database.EnsureDeleted();
        }
    }
}
