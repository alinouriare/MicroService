using CoreDomainApp.Writer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SqlCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraDataSqlCommandsApp.Common
{
    public class MiniblogDbContext : BaseCommandDbContext
    {
        public DbSet<Writer> Writers { get; set; }
        public MiniblogDbContext(DbContextOptions<MiniblogDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(builder);
        }
    }
    public class DbContextBuilder : IDesignTimeDbContextFactory<MiniblogDbContext>
    {
        public MiniblogDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MiniblogDbContext>();
            builder.UseSqlServer("Server =.; Database=MiniBlogDb ;Integrated Security=True; MultipleActiveResultSets=true");
            return new MiniblogDbContext(builder.Options);
        }
    }
}
