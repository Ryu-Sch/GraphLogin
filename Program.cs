using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using UnityGraphProduction.Authentication;
using UnityGraphProduction;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app");
        //builder.RootComponents.Add<HeadOutlet>("head::after");

        builder.Services.AddSingleton<MSGraphClientFactory>();
        builder.Services.AddSingleton<GraphAPIAuthorizationMessageHandler>();
        builder.Services.AddHttpClient("GraphAPI", client => client.BaseAddress = new Uri("https://graph.microsoft.com")).AddHttpMessageHandler<GraphAPIAuthorizationMessageHandler>();


        builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

        builder.Services.AddMsalAuthentication(options =>
        {
            builder.Configuration.Bind("AzureAd", options.ProviderOptions.Authentication);
            options.ProviderOptions.DefaultAccessTokenScopes.Add("User.Read");
            options.ProviderOptions.DefaultAccessTokenScopes.Add("Mail.Read");
        });

        await builder.Build().RunAsync();

    }
}
        

