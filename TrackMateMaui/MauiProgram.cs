using Microsoft.Extensions.Logging;
using TrackMateMaui.Services;
using TrackMateMaui.ViewModels;
using TrackMateMaui.Views;

namespace TrackMateMaui
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

            builder.Services.AddSingleton<TaskStore>();
            builder.Services.AddTransient<ListOfTaskViewModel>();
            builder.Services.AddTransient<ListOfTaskPage>();
            builder.Services.AddTransient<CreateTaskViewModel>();
            builder.Services.AddTransient<CreateTaskPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
