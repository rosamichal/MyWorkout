using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using MyWorkout.Application.Common.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkout.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MyWorkoutDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("MyWorkoutConnectionString")));
            services.AddScoped<IMyWorkoutDbContext, MyWorkoutDbContext>();

            return services;
        }
    }
}
