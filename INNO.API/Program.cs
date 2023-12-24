
using INNO.API.Extantions;
using INNO.Data.DbContexts;
using INNO.Service.Helpers;
using INNO.Service.Interfaces.IExtantions;
using INNO.Service.Mappers;
using INNO.Service.Services;
using Microsoft.EntityFrameworkCore;
using Serilog;


namespace INNO.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .MinimumLevel.Error()
            .WriteTo.File("Log/log.txt",
            rollingInterval: RollingInterval.Minute)
            .CreateLogger();
            builder.Logging.AddSerilog();




            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IFileService, FileService>();
            builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));


           

            builder.Services.AddSessionStore();
            builder.Services.ConfigureJwt(builder.Configuration);
            //builder.Services.AddSwaggerService();
            builder.Services.AddHttpContextAccessor();




            var app = builder.Build();


            // Configure the HTTP request pipeline.
          //  if (app.Environment.IsDevelopment())
          //  {
                app.UseSwagger();
                app.UseSwaggerUI();
           // }

            //EnvironmentHelper.WebRootPath = app.Services.GetRequiredService<IWebHostEnvironment>()?.WebRootPath;
            //if (app.Services.GetService<IHttpContextAccessor>() != null)
            //    HttpContextHelper.Accessor = app.Services.GetRequiredService<IHttpContextAccessor>();
            //if (!Directory.Exists(EnvironmentHelper.AttachmentPath))
            //    Directory.CreateDirectory(EnvironmentHelper.AttachmentPath);
            //if (!Directory.Exists(EnvironmentHelper.FilePath))
            //    Directory.CreateDirectory(EnvironmentHelper.FilePath);




            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}