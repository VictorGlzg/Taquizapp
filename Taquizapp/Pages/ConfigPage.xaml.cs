using Taquizapp.ViewModels.Config;

namespace Taquizapp.Pages;

public partial class ConfigPage : ContentPage
{
	public ConfigPage(ConfigViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}