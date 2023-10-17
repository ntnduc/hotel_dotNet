// See https://aka.ms/new-console-template for more information

using Hotel.Domain.User.Repositories;
using Hotel.Infrastructure.Repositories.User;
using Hotel.Infrastructure.Repositories.UserConfig;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Hotel.Infrastructure;

public static class InfrastructureModule 
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection service,
        ConfigurationManager configurationManager)
    {
        // service.AddDbContext<ApplicationDbContext>();
        service.AddScoped<IUserConfigRepositories, UserConfigRepositories>();
        service.AddScoped<IUserRepositories, UserRepositories>();
        return service;
    }
}