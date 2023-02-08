using Microsoft.Extensions.DependencyInjection;
using PracticomService.Context;
using PracticomService.Repositories;
using PracticomService.Repositories.Interfaces;
using PracticomService.Repositories.Repositories;
using PracticomService.Services.Interfaces;
using PracticomService.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticomService.Services
{
    public static class Extensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped<IUserService,UserService> ();
            services.AddDbContext<IContext, DBContext>();
            services.AddAutoMapper(typeof(Mapping));
            return services;
        }
    }
}
