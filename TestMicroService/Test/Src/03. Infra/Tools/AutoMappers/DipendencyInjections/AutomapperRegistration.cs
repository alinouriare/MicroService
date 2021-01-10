using AutoMapper;
using AutoMappers.Common;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Utilitie.ObjectMappers;

namespace AutoMappers.DipendencyInjections
{
    public static class AutomapperRegistration
    {
        public static IServiceCollection AddAutoMapperProfiles(this IServiceCollection services, IEnumerable<Assembly> assemblies)
        {
            var profileTypes = assemblies
                .SelectMany(x => x.DefinedTypes)
                .Where(type => typeof(Profile).IsAssignableFrom(type)).ToList();
            var profiles = new List<Profile>();
            foreach (var profileType in profileTypes)
            {
                profiles.Add((Profile)Activator.CreateInstance(profileType));
            }
            return services.AddSingleton<IMapperAdapter>(new AutoMapperAdapter(profiles.ToArray()));
        }
    }

}
