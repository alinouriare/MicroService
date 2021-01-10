using CoreDomainApp;
using SqlCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitie;

namespace InfraDataSqlCommandsApp.Common
{
    public class MiniBlogUnitOfWork : BaseEntityFrameworkUnitOfWork<MiniblogDbContext>, IMiniblogUnitOfWork
    {
        public MiniBlogUnitOfWork(MiniblogDbContext dbContext, ZaminServices zaminApplicationContext) : base(dbContext, zaminApplicationContext)
        {
        }
    }
}
