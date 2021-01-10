using CoreDomainApp.Writer.Entities;
using CoreDomainApp.Writer.Repositories;
using InfraDataSqlCommandsApp.Common;
using SqlCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraDataSqlCommandsApp.Writers
{
    public class WriterCommandRepository : BaseCommandRepository<Writer, MiniblogDbContext>, IWriterRepository
    {
        public WriterCommandRepository(MiniblogDbContext dbContext) : base(dbContext)
        {
        }
    }
}
