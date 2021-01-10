using EndPoints.Web.StartupExtentions;
using InfraDataSqlCommandsApp.Common;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utilitie.Configurations;

namespace EndPointsApi
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddZaminApiServices(_configuration);
            services.AddDbContext<MiniblogDbContext>(c => c.UseSqlServer(_configuration.GetConnectionString("MiniBlogCommand_ConnectionString")));

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
            ZaminConfigurations zaminConfigurations)
        {
            app.UseZaminApiConfigure(zaminConfigurations, env);
        }
    }

}
