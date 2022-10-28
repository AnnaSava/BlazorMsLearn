using BlazorHosted.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorHosted.Client.Pages;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<Counter>("#counter-component");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
