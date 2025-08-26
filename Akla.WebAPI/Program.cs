using Akla.Repository.Repositories;
using Akla.Services;
using Akla.SharedData.Context;
using Microsoft.EntityFrameworkCore;

namespace Akla.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<AklaDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("AklaConnectionString"))
                       .UseLazyLoadingProxies()
            );

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddAklaServices();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("MyPolicy", policy =>
                {
                    policy.AllowAnyMethod()
                          .AllowAnyHeader()
                          .AllowAnyOrigin();
                });
            });

            builder.Services.AddControllers();

            // Add Swagger services
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                // Enable Swagger + Swagger UI
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("MyPolicy");

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
