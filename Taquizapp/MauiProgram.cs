namespace Taquizapp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp() =>
        MauiApp.CreateBuilder()
               .UseMauiApp<App>()
               .AddLibraries()
               .AddViewModels()
               .AddServices()
               .AddShellRoutes()
               .AddFonts()
               .Build();
    }
}
