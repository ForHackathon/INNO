using INNO.Data.DbContexts;
using INNO.Data.IRepositories;
using INNO.Data.Repositories;
using INNO.Domain.Entities.Organizations;
using INNO.Domain.Entities.Users;
using INNO.Service.Interfaces.IOrganisations;
using INNO.Service.Interfaces.IStartups;
using INNO.Service.Interfaces.IUsers;
using INNO.Service.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
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

    public static IServiceCollection AddJwtService(this IServiceCollection services, IConfiguration configuration)
    {
        
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            });

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidIssuer = AuthOptions.ISSUER,
                        ValidateAudience = true,
                        ValidAudience = AuthOptions.AUDIENCE,
                        ValidateLifetime = true,
                        IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
                        ValidateIssuerSigningKey = true,
                    };
                });
        return services;

    }

    public static IServiceCollection AddDatabaseSettings(
        this IServiceCollection services, IConfiguration configuration)
    {

        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(configuration["ConnectionStrings:DefaultConnection"], optionsBuilder =>
                optionsBuilder.MigrationsAssembly("INNO.Data")));

        return services;
    }
    

    public static IServiceCollection AddSwaggerService(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            c.IncludeXmlComments(xmlPath);


            c.SwaggerDoc("v1", new OpenApiInfo { Title = "NFU.Backend.Discussion.Api", Version = "v1" });
            var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";

            c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Name = "Authorization",
                Description =
                    "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                In = ParameterLocation.Header,
                Type = SecuritySchemeType.ApiKey
            });

            c.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[] { }
                }
            });
        });
        return services;
    }
}

