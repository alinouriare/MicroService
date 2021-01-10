using ApplicationServices.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Commands
{
   public class CommandResult: ApplicationServiceResult
    {
    }

    public class CommandResult<TData>: CommandResult
    {
        internal TData _data;
        public TData Data
        {
            get
            {
                return _data;
            }
        }
    }
}
