using Microsoft.Extensions.Logging;
using mvvmRepositoryPattern.ViewModels;
using mvvmRepositoryPattern.Views;

namespace mvvmRepositoryPattern
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

            builder.Services.AddSingleton<NotesViewModel>();
            builder.Services.AddSingleton<AllNotesPage>();

            builder.Services.AddSingleton<NoteViewModel>();
            builder.Services.AddSingleton<NotePage>();

            return builder.Build();
        }
    }
}
