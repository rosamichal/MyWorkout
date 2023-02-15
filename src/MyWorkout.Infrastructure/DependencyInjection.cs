using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using MyWorkout.Application.Common.Interfaces;
using MyWorkout.Infrastructure.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkout.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDateTime, DateTimeService>();
            return services;
        }
    }
}
