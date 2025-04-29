using System.Collections.ObjectModel;

namespace Cookpedia.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int PrepTimeMinutes { get; set; }
        public string Difficulty { get; set; }
        public int Calories { get; set; }
        public double Rating { get; set; }
        public string ImageUrl { get; set; }
        public ObservableCollection<Ingredient> Ingredients { get; set; }
        public string Category { get; set; }

        public Recipe()
        {
            Ingredients = new ObservableCollection<Ingredient>();
        }
    }
}
