using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitie.ObjectMappers
{
    public interface IMapperAdapter
    {
        TDestination Map<TSource, TDestination>(TSource source);
    }
}
