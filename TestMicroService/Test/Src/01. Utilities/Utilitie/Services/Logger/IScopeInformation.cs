﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitie.Services.Logger
{
    public interface IScopeInformation
    {
        Dictionary<string, string> HostScopeInfo { get; }
        Dictionary<string, string> RequestScopeInfo { get; }
    }
}
