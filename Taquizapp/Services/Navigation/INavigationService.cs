namespace Taquizapp.Services.Navigation
{
    public interface INavigationService
    {
        Task PopToRootAsync(bool animated = true);
        Task NavigateToAsync(string route, bool animated = true, IDictionary<string, object> routeParameters = null!);
        Task PopAsync();
    }
}
