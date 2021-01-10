using CoreDomainApp.Writer.Entities;
using CoreDomainToolkits.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraDataSqlCommandsApp.Writers
{
    public class WriterConfig : IEntityTypeConfiguration<Writer>
    {
        public void Configure(EntityTypeBuilder<Writer> builder)
        {
            builder.Property(c => c.FirstName).HasConversion(c => c.Value, c => Title.FromString(c));
            builder.Property(c => c.LastName).HasConversion(c => c.Value, c => Title.FromString(c));
        }
    }
}
