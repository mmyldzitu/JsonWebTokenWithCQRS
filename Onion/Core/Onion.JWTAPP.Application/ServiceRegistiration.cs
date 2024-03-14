using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Onion.JWTAPP.Application.Mappings;
using Onion.JWTAPP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Onion.JWTAPP.Application
{
    public static class ServiceRegistiration
    {
        public static void AddApplicationService(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(opt =>
            {
                opt.AddProfiles(new List<Profile>
                {
                   new CategoryProfile()
                });
            });

        }
    }
}
