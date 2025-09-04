using FluentValidation;
using GBSPlans.Application.Interface.Helpers;
using GBSPlans.Application.UseCases.Commons.Behaviours;
using GBSPlans.Application.UseCases.Helpers;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace GBSPlans.Application.UseCases
{
    public static class ConfigureServices
    {
        public static void AddInjectionApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            services.AddSingleton(typeof(IPipelineBehavior<,>), typeof(LoggingBehaviour<,>));
            services.AddSingleton(typeof(IPipelineBehavior<,>), typeof(PerformanceBehaviour<,>));
            services.AddScoped<IExternalApiService, ExternalApiService>();
        }
    }
}
