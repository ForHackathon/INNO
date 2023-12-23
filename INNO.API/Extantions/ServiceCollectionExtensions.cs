using INNO.Data.IRepositories;
using INNO.Data.Repositories;
using INNO.Domain.Entities.Organizations;
using INNO.Domain.Entities.Users;
using INNO.Service.Interfaces.IOrganisations;
using INNO.Service.Interfaces.IStartups;
using INNO.Service.Interfaces.IUsers;
using INNO.Service.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace INNO.API.Extantions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSessionStore(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IGenericRepository<User>, GenericRepository<User>>();
        services.AddScoped<IGenericRepository<OwnerStartup>, GenericRepository<OwnerStartup>>();
        services.AddScoped<IGenericRepository<PastExperience>, GenericRepository<PastExperience>>();
        services.AddScoped<IGenericRepository<Organization>, GenericRepository<Organization>>();

        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IStartupService, StartupService>();
        services.AddScoped<IPastExperienceService, PastExperienceService>();
        services.AddScoped<IOrganisationService, OrganizationService>();

        return services;
    }

    public static IServiceCollection AddJwtService(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        var jwtSettings = configuration.GetSection("Jwt");
        string key = jwtSettings.GetSection("Key")?.Value;

        if (string.IsNullOrEmpty(key))
        {
            throw new InvalidOperationException("Jwt key is missing or invalid.");
        }

        serviceCollection.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = false,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = jwtSettings.GetSection("Issuer").Value,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key))
            };
        });

        return serviceCollection;
    }
}
