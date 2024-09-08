using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Taquizapp.Services.Navigation;

namespace Taquizapp.ViewModels;

public abstract partial class BaseViewModel : ObservableObject, IQueryAttributable
{
    [ObservableProperty]
    string _currentState = States.Success;

    public INavigationService NavigationService { get; }

    public BaseViewModel(INavigationService navigationService)
    {
        NavigationService = navigationService;
    }

    public virtual async Task InitAsync()
    {

    }

    public virtual void ApplyQueryAttributes(IDictionary<string, object> query)
    {
    }

    [RelayCommand]
    public virtual async Task BackButton() { }
}

static class States
{
    public const string Loading = nameof(Loading);
    public const string Success = nameof(Success);
    public const string Error = nameof(Error);
}