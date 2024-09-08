using Taquizapp.ViewModels.StewSelection;

namespace Taquizapp.Pages;

public partial class StewSelectionPage : ContentPage
{
	public StewSelectionPage(StewSelectionViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}