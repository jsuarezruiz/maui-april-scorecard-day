using Cookpedia.ViewModels;

namespace Cookpedia.Views;

public partial class BookmarkView : ContentPage
{
    readonly BookmarkViewModel _viewModel;

    public BookmarkView(BookmarkViewModel viewModel)
	{
		InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }
}