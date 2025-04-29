using Cookpedia.Services;
using Cookpedia.ViewModels;
using Cookpedia.Views;
using Microsoft.Extensions.Logging;

namespace Cookpedia
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

            // Register services
            builder.Services.AddSingleton<RecipeService>();

            // Register pages and viewmodels
            builder.Services.AddTransient<HomeView>();
            builder.Services.AddTransient<HomeViewModel>();

            builder.Services.AddTransient<RecipeDetailsView>();
            builder.Services.AddTransient<RecipeDetailsViewModel>();

            builder.Services.AddTransient<BookmarkView>();
            builder.Services.AddTransient<BookmarkViewModel>();

            return builder.Build();
        }
    }
}
