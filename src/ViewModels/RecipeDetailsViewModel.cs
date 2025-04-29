using Cookpedia.Models;
using Cookpedia.Services;
using System.Windows.Input;

namespace Cookpedia.ViewModels
{
    [QueryProperty(nameof(RecipeId), "id")]
    public class RecipeDetailsViewModel : BaseViewModel
    {
        readonly RecipeService _recipeService;
        int _recipeId;
        Recipe _recipe;

        public int RecipeId
        {
            get => _recipeId;
            set
            {
                _recipeId = value;
                LoadRecipe(value);
            }
        }

        public Recipe Recipe
        {
            get => _recipe;
            set => SetProperty(ref _recipe, value);
        }

        public ICommand BackCommand { get; }
        public ICommand BookmarkCommand { get; }
        public ICommand WatchVideoCommand { get; }

        public RecipeDetailsViewModel(RecipeService recipeService)
        {
            _recipeService = recipeService;
            Title = "Recipe Details";

            BackCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync("..");
            });

            BookmarkCommand = new Command(() =>
            {
                // Implement bookmarking functionality
            });

            WatchVideoCommand = new Command(() =>
            {
                // Implement video functionality
            });
        }

        void LoadRecipe(int recipeId)
        {
            Recipe = _recipeService.GetRecipeById(recipeId);

            if (Recipe != null)
                Title = Recipe.Name;
        }
    }
}
