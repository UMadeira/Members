using MembersWebApp;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace MembersWebApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { 
                BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddMsalAuthentication( options => {
                options.ProviderOptions.AdditionalScopesToConsent.Add("https://graph.microsoft.com/User.Read");
                options.ProviderOptions.DefaultAccessTokenScopes.Add("api://members/groups.get");
                builder.Configuration.Bind("AzureAd", options.ProviderOptions.Authentication);
            });

            await builder.Build().RunAsync();
        }
    }
}