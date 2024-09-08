namespace Taquizapp.Services.Navigation
{
    public partial class NavigationService : INavigationService
    {
        public Task NavigateToAsync(string route, bool animated = true, IDictionary<string, object> routeParameters = null)
        {
            var shellNavigation = new ShellNavigationState(route);

            return routeParameters != null
                ? Shell.Current.GoToAsync(shellNavigation, animated, routeParameters)
                : Shell.Current.GoToAsync(shellNavigation, animated);
        }
        public async Task PopAsync() => await Shell.Current.GoToAsync("..");
        public async Task PopToRootAsync(bool animated) => await Shell.Current.Navigation.PopToRootAsync(animated);
    }
}
