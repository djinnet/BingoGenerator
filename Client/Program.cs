using Append.Blazor.Printing;
using BingoGenerator.Core.Services;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BingoGenerator;
public class Program
{
    public static async Task Main(string[] args)
    {
        try
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddScoped<BingoService>();
            builder.Services.AddScoped<IPrintingService, PrintingService>();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
        catch (Exception)
        {

            throw;
        }

    }
}
