using CommunityToolkit.Maui;
using Taquizapp.Pages;
using Taquizapp.Services.Navigation;
using Taquizapp.ViewModels.StewSelection;

namespace Taquizapp;
public static class Extensions
{
    public static MauiAppBuilder AddViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<StewSelectionViewModel>();
        return mauiAppBuilder;
    }

    public static MauiAppBuilder AddShellRoutes(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddTransientWithShellRoute<StewSelectionPage, StewSelectionViewModel>(nameof(StewSelectionPage));
        return mauiAppBuilder;
    }

    public static MauiAppBuilder AddLibraries(this MauiAppBuilder mauiAppBuilder)
    {
        Akavache.Registrations.Start("Taquizapp");
        return mauiAppBuilder;
    }

    public static MauiAppBuilder AddServices(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<INavigationService, NavigationService>();
        return mauiAppBuilder;
    }

    public static MauiAppBuilder AddFonts(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        });

        return mauiAppBuilder;
    }
}
