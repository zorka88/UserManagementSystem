using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementSystem.Contracts;
using UserManagementSystem.Data;
using UserManagementSystem.JwtFeatures;
using UserManagementSystem.Repositories;
//using UserManagementSystem.Repositories;

namespace UserManagementSystem.IoC
{
    public static class Repository
    {
        public static IServiceCollection Configure(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddScoped<JwtHandler>();
            return services;
        }
    }
}
