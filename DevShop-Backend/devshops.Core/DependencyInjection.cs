using devshops.Core.Developer;
using devshops.Core.Position;
using devshops.Core.Repository.Developer;
using devshops.Core.Repository.DeveloperPosition;
using devshops.Core.Repository.Position;
using devshops.Core.Services.DeveloperPosition;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devshops.Core
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCoreInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDeveloperRepository, DeveloperRepository>();
            services.AddTransient<IPositionRepository, PositionRepository>();
            services.AddTransient<IDeveloperPositionRepository, DeveloperPositionRepository>();

            services.AddTransient<IDeveloperService, DeveloperService>();
            services.AddTransient<IPositionService, PositionService>();
            services.AddTransient<IDeveloperPositionService, DeveloperPositionService>();
            
            return services;
        }
    }
}
