using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitie.ObjectMappers;

namespace AutoMappers.Common
{
    public class AutoMapperAdapter : IMapperAdapter
    {

        private readonly MapperConfiguration _mapperConfiguration;
        private readonly IMapper _mapper;

        public AutoMapperAdapter(params Profile[] profiles)
        {
            _mapperConfiguration = new MapperConfiguration(c =>
            {
                foreach (var profile in profiles)
                {
                    c.AddProfile(profile);
                }
            });
            _mapper = _mapperConfiguration.CreateMapper();
        }
        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return _mapper.Map<TDestination>(source);
        }
    }
}
