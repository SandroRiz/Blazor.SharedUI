using Blazor.SharedUI.MAUI.Services;
using Blazor.SharedUI.Shared;
using Blazor.SharedUI.WASM;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:44369") });
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<IPlatformService, PlatformService>();
await builder.Build().RunAsync();
