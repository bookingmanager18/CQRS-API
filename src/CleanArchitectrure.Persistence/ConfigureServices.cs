using GBSPlans.Application.Interface.Persistence;
using GBSPlans.Persistence.Contexts;
using GBSPlans.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace GBSPlans.Persistence
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInjectionPersistence(this IServiceCollection services)
        {
            services.AddSingleton<DapperContext>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
