using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Libreria.Application.ServiciesConfiguration;

public static class AppServiciesRegistration
{
    public static IServiceCollection AddAppServices(this IServiceCollection services)
    {
        services.AddMediatR(options => options.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        return services;
    }
}