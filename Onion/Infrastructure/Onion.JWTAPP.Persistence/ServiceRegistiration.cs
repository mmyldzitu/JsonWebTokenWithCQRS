using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Onion.JWTAPP.Application.Interfaces;
using Onion.JWTAPP.Persistence.Context;
using Onion.JWTAPP.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onion.JWTAPP.Persistence
{
    public  static class ServiceRegistiration
    {
        public static void AddPersistenceServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<JwtContext>(opt =>
            {

                opt.UseSqlServer(configuration.GetConnectionString("Local"));

            });
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

        }
    }
}
