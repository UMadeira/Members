using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.DependencyInjection;

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

            var services = new ServiceCollection();
            services.AddTransient<MainForm>();
            var serviceProvider = services.BuildServiceProvider();

            var form = serviceProvider.GetService<MainForm>();
            Application.Run( form );
        }
    }
}