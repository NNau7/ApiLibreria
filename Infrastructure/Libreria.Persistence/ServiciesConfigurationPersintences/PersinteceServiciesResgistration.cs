using Libreria.Domain;
using Libreria.Domain.Interfaces;
using Libreria.Persistence.Context;
using Libreria.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Libreria.Persistence.ServiciesConfigurationPersintences;

public static class PersinteceServiciesResgistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<LibreriaDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("LibreriaConnection")));
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IMemberRepository, MemberRepository>();
        
        return services;
    }
        
    
}