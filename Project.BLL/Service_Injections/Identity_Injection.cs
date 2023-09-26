using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Project.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAL.Context;

namespace Project.BLL.Service_Injections
{
    public static class Identity_Injection
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services)
        {
            services.AddIdentity<User, Role>(x =>
            {
                x.Password.RequireDigit = false;
                x.Password.RequireLowercase = false;
                x.Password.RequireUppercase = false;
                x.Password.RequireNonAlphanumeric = false;
                x.Password.RequiredLength = 8;
            }).AddEntityFrameworkStores<MyContext>();

            return services;
        }
    }
}
