
/*
 * Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
 */

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;

using Members.Core.Repositories;
using Members.Data;
using Members.Models.Domain;
using System.Configuration;

namespace MembersApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("Members");

            // Add services to the container.

            builder.Services
                .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddMicrosoftIdentityWebApi( builder.Configuration.GetSection("AzureAd") );

            builder.Services.AddCors( options => {
                options.AddPolicy(name: "MembersCorsPolicy",
                    policy => {
                        policy.WithOrigins("https://localhost:7102"); // MembersWebApp
                    });
                options.AddPolicy(name: "AllowEveryonePolicy",
                    policy => {
                        policy.AllowAnyOrigin()
                              .AllowAnyHeader()
                              .AllowAnyMethod(); } );
            });

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            //builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<MembersContext>(options => options.UseSqlServer( connectionString ) );
            builder.Services.AddSingleton<IFactory>(sp => new Factory(typeof(Person), typeof(Group)));
            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
            builder.Services.AddTransient<IUnitOfWorkAsync, UnitOfWorkAsync>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if ( app.Environment.IsDevelopment() )
            {
                //app.UseSwagger();
                //app.UseSwaggerUI();
            }

            app.UseCors("AllowEveryonePolicy");

            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}