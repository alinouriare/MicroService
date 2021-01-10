using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Common
{
    public enum ApplicationServiceStatus
    {
        Ok = 1,
        NotFound = 2,
        ValidationError = 3,
        InvalidDomainState = 4,
        Exception = 5,
    }
}
