using Cookpedia.Models;
using Cookpedia.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Cookpedia.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        readonly RecipeService _recipeService;
        string _userName;
        ObservableCollection<Recipe> _recommendedRecipes;
        ObservableCollection<Recipe> _weeklyRecipes;
        ObservableCollection<Category> _categories;

        public string UserName
        {
            get => _userName;
            set => SetProperty(ref _userName, value);
        }

        public ObservableCollection<Recipe> RecommendedRecipes
        {
            get => _recommendedRecipes;
            set => SetProperty(ref _recommendedRecipes, value);
        }

        public ObservableCollection<Recipe> WeeklyRecipes
        {
            get => _weeklyRecipes;
            set => SetProperty(ref _weeklyRecipes, value);
        }

        public ObservableCollection<Category> Categories
        {
            get => _categories;
            set => SetProperty(ref _categories, value);
        }

        public ICommand RecipeSelectedCommand { get; }
        public ICommand CategorySelectedCommand { get; }
        public ICommand SearchCommand { get; }

        public HomeViewModel(RecipeService recipeService)
        {
            _recipeService = recipeService;
            Title = "Home";
            UserName = "Anne";
            LoadData();

            RecipeSelectedCommand = new Command<Recipe>(async (recipe) =>
            {
                if (recipe != null)
                {
                    await Shell.Current.GoToAsync($"recipedetails?id={recipe.Id}");
                }
            });

            CategorySelectedCommand = new Command<Category>(async (category) =>
            {
                if (category != null)
                {
                    // Navigate to category page or filter recipes
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
            RecommendedRecipes = new ObservableCollection<Recipe>(allRecipes.Take(10));
            WeeklyRecipes = new ObservableCollection<Recipe>(allRecipes.Skip(1).Take(4));
            Categories = _recipeService.GetCategories();
        }
    }
}
