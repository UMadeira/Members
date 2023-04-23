
/*
 * Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
 */

using Microsoft.EntityFrameworkCore;

using Members.Core.Repositories;
using Members.Data;
using Members.Models.Domain;

namespace MembersApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("Members");

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<MembersContext>(options => options.UseSqlServer( connectionString ) );
            builder.Services.AddSingleton<IFactory>(sp => new Factory(typeof(Person), typeof(Group)));
            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if ( app.Environment.IsDevelopment() )
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}