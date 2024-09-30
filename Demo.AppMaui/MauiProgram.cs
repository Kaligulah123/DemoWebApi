using Microsoft.Extensions.Logging;
using Demo.AppMaui.MVVM.ViewModels;
using Demo.AppMaui.MVVM.Views;

namespace Demo.AppMaui
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            //builder.Services.AddDemoApiClientService();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainPageViewModel>();

            builder.Services.AddSingleton<NewPage1>();
            builder.Services.AddSingleton<NewPage1ViewModel>();

            return builder.Build();
        }
    }
}
