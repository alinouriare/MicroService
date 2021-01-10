using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitie.Services.Chaching;

namespace CachingMicrosoft
{
    public class InMemoryCacheAdapter : ICacheAdapter
    {
        private readonly IMemoryCache _memoryCache;


        public InMemoryCacheAdapter(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }


        public void Add<TInput>(string key, TInput obj, DateTime? AbsoluteExpiration, TimeSpan? SlidingExpiration)
        {
            _memoryCache.Set(key, obj, new MemoryCacheEntryOptions
            {
                AbsoluteExpiration = AbsoluteExpiration,
                SlidingExpiration = SlidingExpiration
            });
        }

        public TOutput Get<TOutput>(string key)
        {
            var result = _memoryCache.TryGetValue(key, out TOutput resultObject);
            return resultObject;

        }

        public void RemoveCache(string key)
        {
            _memoryCache.Remove(key);
        }
    }
}
