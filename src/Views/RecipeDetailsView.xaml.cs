using Cookpedia.ViewModels;

namespace Cookpedia.Views;

public partial class RecipeDetailsView : ContentPage
{
    readonly RecipeDetailsViewModel _viewModel;

    public RecipeDetailsView(RecipeDetailsViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }
}