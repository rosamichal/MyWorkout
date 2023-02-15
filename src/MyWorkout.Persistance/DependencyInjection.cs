using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
            services.AddDbContext<TasksLogDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("TasksLogConnectionString")));
            services.AddScoped<ITasksLogDbContext, TasksLogDbContext>();

            return services;
        }
    }
}
