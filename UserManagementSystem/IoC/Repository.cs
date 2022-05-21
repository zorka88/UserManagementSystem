using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagementSystem.Contracts;
using UserManagementSystem.Data;
//using UserManagementSystem.Repositories;

namespace UserManagementSystem.IoC
{
    public static class Repository
    {
        public static IServiceCollection Configure(this IServiceCollection services)
        {
            //services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
