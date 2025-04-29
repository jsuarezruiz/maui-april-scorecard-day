using Cookpedia.ViewModels;

namespace Cookpedia.Views;

public partial class HomeView : ContentPage
{
    readonly HomeViewModel _viewModel;

    public HomeView(HomeViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }
}