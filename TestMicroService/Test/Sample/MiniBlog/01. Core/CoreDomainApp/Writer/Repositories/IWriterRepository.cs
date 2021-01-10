using CoreDomain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreDomainApp.Writer.Entities;
using System.Threading.Tasks;

namespace CoreDomainApp.Writer.Repositories
{
    public interface IWriterRepository : ICommandRepository<CoreDomainApp.Writer.Entities.Writer>
    {
    }
}
