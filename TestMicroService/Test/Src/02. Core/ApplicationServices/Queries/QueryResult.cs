using ApplicationServices.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Queries
{
    public sealed class QueryResult<TData> : ApplicationServiceResult
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
