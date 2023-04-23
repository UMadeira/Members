using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

using Members.Core.Repositories;
using Members.Models.Domain;
using Members.Data;

namespace MembersApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                //.AddUserSecrets<Program>()
                .Build();

            var connectionString = config.GetConnectionString("Members");

            var services = new ServiceCollection();
            services.AddDbContext<MembersContext>(options => options.UseSqlServer(connectionString));
            services.AddSingleton<IFactory>( sp => new Factory(typeof(Person), typeof(Group)) );
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<MainForm>();
            var serviceProvider = services.BuildServiceProvider();

            var form = serviceProvider.GetService<MainForm>();
            Application.Run( form );
        }
    }
}