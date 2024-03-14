using System;
using DDD.Library.Infrastructure.ConfigurationModels;
using DDD.Library.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DDD.Library.API.Extensions
{
	public static class ServiceCollectionExtension
	{
        public static void AddAppDbContext(this IServiceCollection services,string connectionString)
		{
            services.AddDbContext<AppDbContext>(o =>
            {
                o.UseSqlServer(connectionString);
            });
        }
	}
}

