﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EndPoints.Web.StartupExtentions
{
    public static class Extentions
    {
        public static IServiceCollection AddZaminDependencies(this IServiceCollection services,
            params string[] assemblyNamesForSearch)
        {

            var assemblies = GetAssemblies(assemblyNamesForSearch);
            services.AddApplicationServices(assemblies).AddDataAccess(assemblies).AddZaminServices(assemblies);
            return services;
        }

        public static IServiceCollection AddWithTransientLifetime(this IServiceCollection services,
            IEnumerable<Assembly> assembliesForSearch,
            params Type[] assignableTo)
        {
            services.Scan(s => s.FromAssemblies(assembliesForSearch)
                .AddClasses(c => c.AssignableToAny(assignableTo))
                .AsImplementedInterfaces()
                .WithTransientLifetime());
            return services;
        }
        public static IServiceCollection AddWithScopedLifetime(this IServiceCollection services,
           IEnumerable<Assembly> assembliesForSearch,
           params Type[] assignableTo)
        {
            services.Scan(s => s.FromAssemblies(assembliesForSearch)
                .AddClasses(c => c.AssignableToAny(assignableTo))
                .AsImplementedInterfaces()
                .WithScopedLifetime());
            return services;
        }

        public static IServiceCollection AddWithSingletonLifetime(this IServiceCollection services,
            IEnumerable<Assembly> assembliesForSearch,
            params Type[] assignableTo)
        {
            services.Scan(s => s.FromAssemblies(assembliesForSearch)
                .AddClasses(c => c.AssignableToAny(assignableTo))
                .AsImplementedInterfaces()
                .WithSingletonLifetime());
            return services;
        }



        private static List<Assembly> GetAssemblies(string[] assmblyName)
        {

            var assemblies = new List<Assembly>();
            var dependencies = DependencyContext.Default.RuntimeLibraries;
            foreach (var library in dependencies)
            {
                if (IsCandidateCompilationLibrary(library, assmblyName))
                {
                    var assembly = Assembly.Load(new AssemblyName(library.Name));
                    assemblies.Add(assembly);
                }
            }
            return assemblies;
        }
        private static bool IsCandidateCompilationLibrary(RuntimeLibrary compilationLibrary, string[] assmblyName)
        {
            string[] con = { "Utilitie" , "ApplicationServices", "CoreDomain", "CoreDomainToolkits", "Data", "Events",
                "Messaging","Tools","EndPoints.Web","ApplicationServicesApp","CoreDomainApp","InfraDataSqlCommandsApp",
                 "EndPointsApi",
            //"AutoMappers",
                "CachingMicrosoft","LocalizationsMicrosoft","LocalizerParrot","SrlzrNewtonSoft",
            "IdempotentConsumers","IdempotentConsumersStoreSql","MessageBusRabbitMq","Outbox","PoolingPublisher","SqlQueries","DataSql",
            "SqlCommands"};
           //var aa= compilationLibrary.Name;
           // var aas = compilationLibrary.Dependencies;
            //con.Any(c => c.Contains(compilationLibrary.Name.Contains(c)));
            return con.Any(c => c.Contains(compilationLibrary.Name));

            //return assmblyName.Any(d => compilationLibrary.Name.Contains(d))
            //    || compilationLibrary.Dependencies.Any(d => assmblyName.Any(c => d.Name.Contains(c)));
        }

    }

}
