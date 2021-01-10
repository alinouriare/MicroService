using CoreDomain.People.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Zamin.Core.Domain.TacticalPatterns;

namespace CommandSql.People
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(c => c.Id).HasConversion(c => c.Value, c => BusinessId.FromGuid(c));
        }
    }
}
