using Cookpedia.Models;
using Cookpedia.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Cookpedia.ViewModels
{
    public class BookmarkViewModel : BaseViewModel
    {
        readonly RecipeService _recipeService;
        ObservableCollection<Recipe> _recentlyViewedRecipes;
        ObservableCollection<Recipe> _madeItRecipes;
        ObservableCollection<Recipe> _breakfastRecipes;

        public ObservableCollection<Recipe> RecentlyViewedRecipes
        {
            get => _recentlyViewedRecipes;
            set => SetProperty(ref _recentlyViewedRecipes, value);
        }

        public ObservableCollection<Recipe> MadeItRecipes
        {
            get => _madeItRecipes;
            set => SetProperty(ref _madeItRecipes, value);
        }

        public ObservableCollection<Recipe> BreakfastRecipes
        {
            get => _breakfastRecipes;
            set => SetProperty(ref _breakfastRecipes, value);
        }

        public ICommand RecipeSelectedCommand { get; }
        public ICommand SearchCommand { get; }

        public BookmarkViewModel(RecipeService recipeService)
        {
            _recipeService = recipeService;
            Title = "Bookmark";
            LoadData();

            RecipeSelectedCommand = new Command<Recipe>(async (recipe) =>
            {
                if (recipe != null)
                {
                    await Shell.Current.GoToAsync($"recipedetails?id={recipe.Id}");
                }
            });

            SearchCommand = new Command<string>(async (query) =>
            {
                if (!string.IsNullOrWhiteSpace(query))
                {
                    // Implement search functionality
                }
            });
        }

        void LoadData()
        {
            var allRecipes = _recipeService.GetAllRecipes();
            RecentlyViewedRecipes = new ObservableCollection<Recipe>(allRecipes.Take(2));
            MadeItRecipes = new ObservableCollection<Recipe>(allRecipes.Take(2));
            BreakfastRecipes = new ObservableCollection<Recipe>(
                allRecipes.Where(r => r.Category == "Breakfast").Take(2));
        }
    }
}
