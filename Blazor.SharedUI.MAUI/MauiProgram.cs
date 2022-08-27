using Blazor.SharedUI.MAUI.Services;
using Blazor.SharedUI.Shared;
using Microsoft.AspNetCore.Components.WebView.Maui;

namespace Blazor.SharedUI.MAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
#endif
            builder.Services.AddSingleton<WeatherForecastService>();

#if ANDROID
            builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri("http://10.0.2.2:5211") });
#else
            builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7211") });
#endif
            builder.Services.AddSingleton<IPlatformService, PlatformService>();
            return builder.Build();
        }
    }
}