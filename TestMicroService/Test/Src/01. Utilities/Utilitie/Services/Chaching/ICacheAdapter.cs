﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitie.Services.Chaching
{
    public interface ICacheAdapter
    {
        void Add<TInput>(string key, TInput obj, DateTime? AbsoluteExpiration, TimeSpan? SlidingExpiration);
        TOutput Get<TOutput>(string key);
        void RemoveCache(string key);
    }
}
