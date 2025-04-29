using Cookpedia.Models;
using System.Collections.ObjectModel;

namespace Cookpedia.Services
{
    public class RecipeService
    {
        public ObservableCollection<Recipe> GetAllRecipes()
        {
            return new ObservableCollection<Recipe>
            {
                new Recipe
                {
                    Id = 1,
                    Name = "Choco Macarons",
                    Author = "Rachel William",
                    Description = "Chocolate is the best kind of dessert! These choco macarons are simply heavenly! Delicate little cookies filled with chocolate ganache.",
                    PrepTimeMinutes = 30,
                    Difficulty = "Medium",
                    Calories = 512,
                    Rating = 4.5,
                    ImageUrl = "choco_macarons.jpg",
                    Category = "Dessert",
                    Ingredients = new ObservableCollection<Ingredient>
                    {
                        new Ingredient { Name = "Granulated sugar", Amount = "160 g", ImageUrl = "sugar.png" },
                        new Ingredient { Name = "Ground almond", Amount = "160 g", ImageUrl = "almond.png" },
                        new Ingredient { Name = "Dark chocolate", Amount = "110 g", ImageUrl = "chocolate.png" }
                    }
                },
                new Recipe
                {
                    Id = 2,
                    Name = "Creamy Pasta",
                    Author = "David Charles",
                    Description = "Delicious creamy pasta with fresh ingredients.",
                    PrepTimeMinutes = 20,
                    Difficulty = "Easy",
                    Calories = 450,
                    Rating = 4.2,
                    ImageUrl = "creamy_pasta.jpg",
                    Category = "Dinner",
                    Ingredients = new ObservableCollection<Ingredient>
                    {
                        new Ingredient { Name = "Durum Wheat Spaghetti Pasta", Amount = "250 g", ImageUrl = "spaghetti.png" },
                        new Ingredient { Name = "Tomatoes", Amount = "500 g", ImageUrl = "tomatoes.png" },
                        new Ingredient { Name = "Garlic", Amount = "6 cloves", ImageUrl = "garlic.png" },
                        new Ingredient { Name = "Onion", Amount = "1", ImageUrl = "onion.png" },
                        new Ingredient { Name = "Basil Leaves", Amount = "4 sprigs", ImageUrl = "basil.png" },
                        new Ingredient { Name = "Dried Oregano", Amount = "1 tsp", ImageUrl = "oregano.png" },
                        new Ingredient { Name = "Red Chilli Flakes", Amount = "1 tsp", ImageUrl = "chilli_flakes.png" },
                        new Ingredient { Name = "Fresh Cream", Amount = "1/4 cup", ImageUrl = "cream.png" },
                        new Ingredient { Name = "Extra Virgin Olive Oil", Amount = "2 tbsp", ImageUrl = "olive_oil.png" },
                        new Ingredient { Name = "Salt and Pepper", Amount = "To taste", ImageUrl = "salt_pepper.png" }
                    }
                },
                new Recipe
                {
                    Id = 3,
                    Name = "Chicken Salad",
                    Author = "Sam Johnson",
                    Description = "Healthy chicken salad with fresh vegetables.",
                    PrepTimeMinutes = 15,
                    Difficulty = "Easy",
                    Calories = 320,
                    Rating = 4.0,
                    ImageUrl = "chicken_salad.jpg",
                    Category = "Lunch",
                    Ingredients = new ObservableCollection<Ingredient>
                    {
                        new Ingredient { Name = "Cooked Chicken Breast", Amount = "2 cups", ImageUrl = "chicken.png" },
                        new Ingredient { Name = "Celery", Amount = "1 stalk", ImageUrl = "celery.png" },
                        new Ingredient { Name = "Mayonnaise", Amount = "1/2 cup", ImageUrl = "mayonnaise.png" },
                        new Ingredient { Name = "Lemon Juice", Amount = "1 tbsp", ImageUrl = "lemon.png" },
                        new Ingredient { Name = "Black Pepper", Amount = "1/4 tsp", ImageUrl = "black_pepper.png" },
                        new Ingredient { Name = "Almonds", Amount = "1/2 cup", ImageUrl = "almonds.png" }
                    }
                },
                new Recipe
                {
                    Id = 4,
                    Name = "Spaghetti Carbonara",
                    Author = "Giovanni Rossi",
                    Description = "Classic Italian pasta dish made with eggs, cheese, pancetta, and black pepper.",
                    PrepTimeMinutes = 25,
                    Difficulty = "Medium",
                    Calories = 550,
                    Rating = 4.8,
                    ImageUrl = "carbonara.jpg",
                    Category = "Dinner",
                    Ingredients = new ObservableCollection<Ingredient>
                    {
                        new Ingredient { Name = "Spaghetti", Amount = "250 g", ImageUrl = "spaghetti.png" },
                        new Ingredient { Name = "Pancetta", Amount = "100 g", ImageUrl = "pancetta.png" },
                        new Ingredient { Name = "Eggs", Amount = "2", ImageUrl = "eggs.png" },
                        new Ingredient { Name = "Parmesan cheese", Amount = "50 g", ImageUrl = "parmesan.png" },
                        new Ingredient { Name = "Black pepper", Amount = "1 tsp", ImageUrl = "black_pepper.png" }
                    }
                },
                new Recipe
                {
                    Id = 5,
                    Name = "Greek Salad",
                    Author = "Nikos Papadopoulos",
                    Description = "Refreshing Mediterranean salad with feta cheese, olives, and fresh vegetables.",
                    PrepTimeMinutes = 15,
                    Difficulty = "Easy",
                    Calories = 320,
                    Rating = 4.6,
                    ImageUrl = "greek_salad.jpg",
                    Category = "Lunch",
                    Ingredients = new ObservableCollection<Ingredient>
                    {
                        new Ingredient { Name = "Tomatoes", Amount = "200 g", ImageUrl = "tomatoes.png" },
                        new Ingredient { Name = "Cucumber", Amount = "150 g", ImageUrl = "cucumber.png" },
                        new Ingredient { Name = "Feta cheese", Amount = "100 g", ImageUrl = "feta.png" },
                        new Ingredient { Name = "Black olives", Amount = "50 g", ImageUrl = "olives.png" },
                        new Ingredient { Name = "Olive oil", Amount = "2 tbsp", ImageUrl = "olive_oil.png" }
                    }
                },
                new Recipe
                {
                    Id = 6,
                    Name = "Chicken Tikka Masala",
                    Author = "Rajesh Kumar",
                    Description = "Popular Indian dish featuring marinated chicken cooked in a creamy tomato sauce.",
                    PrepTimeMinutes = 40,
                    Difficulty = "Medium",
                    Calories = 600,
                    Rating = 4.9,
                    ImageUrl = "chicken_tikka.jpg",
                    Category = "Dinner",
                    Ingredients = new ObservableCollection<Ingredient>
                    {
                        new Ingredient { Name = "Chicken breast", Amount = "300 g", ImageUrl = "chicken.png" },
                        new Ingredient { Name = "Tomato puree", Amount = "200 ml", ImageUrl = "tomato_puree.png" },
                        new Ingredient { Name = "Yogurt", Amount = "100 g", ImageUrl = "yogurt.png" },
                        new Ingredient { Name = "Garam masala", Amount = "1 tbsp", ImageUrl = "garam_masala.png" },
                        new Ingredient { Name = "Garlic", Amount = "3 cloves", ImageUrl = "garlic.png" }
                    }
                },
                new Recipe
                {
                    Id = 7,
                    Name = "French Onion Soup",
                    Author = "Pierre Leclerc",
                    Description = "Rich and flavorful soup made with caramelized onions and topped with melted cheese.",
                    PrepTimeMinutes = 50,
                    Difficulty = "Medium",
                    Calories = 450,
                    Rating = 4.7,
                    ImageUrl = "onion_soup.jpg",
                    Category = "Dinner",
                    Ingredients = new ObservableCollection<Ingredient>
                    {
                        new Ingredient { Name = "Onions", Amount = "500 g", ImageUrl = "onions.png" },
                        new Ingredient { Name = "Beef broth", Amount = "1 liter", ImageUrl = "broth.png" },
                        new Ingredient { Name = "Butter", Amount = "50 g", ImageUrl = "butter.png" },
                        new Ingredient { Name = "Gruyère cheese", Amount = "100 g", ImageUrl = "cheese.png" },
                        new Ingredient { Name = "Baguette slices", Amount = "4", ImageUrl = "baguette.png" }
                    }
                },
                new Recipe
                {
                    Id = 8,
                    Name = "Japanese Sushi Rolls",
                    Author = "Hiroshi Tanaka",
                    Description = "Traditional sushi rolls made with fresh fish, rice, and seaweed.",
                    PrepTimeMinutes = 45,
                    Difficulty = "Hard",
                    Calories = 350,
                    Rating = 4.9,
                    ImageUrl = "sushi.jpg",
                    Category = "Dinner",
                    Ingredients = new ObservableCollection<Ingredient>
                    {
                        new Ingredient { Name = "Sushi rice", Amount = "250 g", ImageUrl = "rice.png" },
                        new Ingredient { Name = "Nori seaweed", Amount = "5 sheets", ImageUrl = "nori.png" },
                        new Ingredient { Name = "Salmon", Amount = "200 g", ImageUrl = "salmon.png" },
                        new Ingredient { Name = "Avocado", Amount = "1", ImageUrl = "avocado.png" },
                        new Ingredient { Name = "Soy sauce", Amount = "2 tbsp", ImageUrl = "soy_sauce.png" }
                    }
                },
                new Recipe
                {
                    Id = 9,
                    Name = "Mexican Tacos",
                    Author = "Carlos Ramirez",
                    Description = "Authentic street-style tacos with seasoned beef, fresh toppings, and corn tortillas.",
                    PrepTimeMinutes = 30,
                    Difficulty = "Easy",
                    Calories = 500,
                    Rating = 4.8,
                    ImageUrl = "tacos.jpg",
                    Category = "Dinner",
                    Ingredients = new ObservableCollection<Ingredient>
                    {
                        new Ingredient { Name = "Ground beef", Amount = "300 g", ImageUrl = "beef.png" },
                        new Ingredient { Name = "Corn tortillas", Amount = "6", ImageUrl = "tortillas.png" },
                        new Ingredient { Name = "Onions", Amount = "1", ImageUrl = "onions.png" },
                        new Ingredient { Name = "Cilantro", Amount = "1 bunch", ImageUrl = "cilantro.png" },
                        new Ingredient { Name = "Lime", Amount = "1", ImageUrl = "lime.png" }
                    }
                },
                new Recipe
                {
                    Id = 10,
                    Name = "Thai Green Curry",
                    Author = "Somsak Chai",
                    Description = "Spicy and aromatic Thai curry made with coconut milk and green curry paste.",
                    PrepTimeMinutes = 35,
                    Difficulty = "Medium",
                    Calories = 550,
                    Rating = 4.7,
                    ImageUrl = "green_curry.jpg",
                    Category = "Dinner",
                    Ingredients = new ObservableCollection<Ingredient>
                    {
                        new Ingredient { Name = "Chicken breast", Amount = "300 g", ImageUrl = "chicken.png" },
                        new Ingredient { Name = "Coconut milk", Amount = "400 ml", ImageUrl = "coconut_milk.png" },
                        new Ingredient { Name = "Green curry paste", Amount = "2 tbsp", ImageUrl = "curry_paste.png" },
                        new Ingredient { Name = "Bamboo shoots", Amount = "100 g", ImageUrl = "bamboo.png" },
                        new Ingredient { Name = "Thai basil", Amount = "1 bunch", ImageUrl = "basil.png" }
                    }
                },
                new Recipe
                {
                    Id = 11,
                    Name = "Brazilian Feijoada",
                    Author = "Fernanda Souza",
                    Description = "Traditional Brazilian black bean stew with pork and beef.",
                    PrepTimeMinutes = 90,
                    Difficulty = "Hard",
                    Calories = 700,
                    Rating = 4.9,
                    ImageUrl = "feijoada.jpg",
                    Category = "Dinner",
                    Ingredients = new ObservableCollection<Ingredient>
                    {
                        new Ingredient { Name = "Black beans", Amount = "500 g", ImageUrl = "beans.png" },
                        new Ingredient { Name = "Pork ribs", Amount = "300 g", ImageUrl = "pork.png" },
                        new Ingredient { Name = "Beef sausage", Amount = "200 g", ImageUrl = "sausage.png" },
                        new Ingredient { Name = "Garlic", Amount = "4 cloves", ImageUrl = "garlic.png" },
                        new Ingredient { Name = "Bay leaves", Amount = "2", ImageUrl = "bay_leaves.png" }
                    }
                },
                new Recipe
                {
                    Id = 12,
                    Name = "Italian Margherita Pizza",
                    Author = "Luca Bianchi",
                    Description = "Classic Neapolitan pizza with fresh tomatoes, mozzarella, and basil.",
                    PrepTimeMinutes = 30,
                    Difficulty = "Medium",
                    Calories = 700,
                    Rating = 4.8,
                    ImageUrl = "margherita_pizza.jpg",
                    Category = "Dinner",
                    Ingredients = new ObservableCollection<Ingredient>
                    {
                        new Ingredient { Name = "Pizza dough", Amount = "1 ball", ImageUrl = "pizza_dough.png" },
                        new Ingredient { Name = "Tomato sauce", Amount = "150 ml", ImageUrl = "tomato_sauce.png" },
                        new Ingredient { Name = "Mozzarella cheese", Amount = "200 g", ImageUrl = "mozzarella.png" },
                        new Ingredient { Name = "Fresh basil", Amount = "5 leaves", ImageUrl = "basil.png" },
                        new Ingredient { Name = "Olive oil", Amount = "1 tbsp", ImageUrl = "olive_oil.png" }
                    }
                },
                new Recipe
                {
                    Id = 13,
                    Name = "Spanish Paella",
                    Author = "Maria Fernandez",
                    Description = "Traditional Spanish rice dish with seafood, saffron, and vegetables.",
                    PrepTimeMinutes = 50,
                    Difficulty = "Hard",
                    Calories = 650,
                    Rating = 4.9,
                    ImageUrl = "paella.jpg",
                    Category = "Dinner",
                    Ingredients = new ObservableCollection<Ingredient>
                    {
                        new Ingredient { Name = "Bomba rice", Amount = "250 g", ImageUrl = "rice.png" },
                        new Ingredient { Name = "Shrimp", Amount = "200 g", ImageUrl = "shrimp.png" },
                        new Ingredient { Name = "Mussels", Amount = "150 g", ImageUrl = "mussels.png" },
                        new Ingredient { Name = "Saffron", Amount = "1 pinch", ImageUrl = "saffron.png" },
                        new Ingredient { Name = "Bell peppers", Amount = "1", ImageUrl = "bell_pepper.png" }
                    }
                },
                new Recipe
                {
                    Id = 14,
                    Name = "French Ratatouille",
                    Author = "Pierre Leclerc",
                    Description = "A rustic vegetable stew made with zucchini, eggplant, tomatoes, and herbs.",
                    PrepTimeMinutes = 40,
                    Difficulty = "Medium",
                    Calories = 300,
                    Rating = 4.7,
                    ImageUrl = "ratatouille.jpg",
                    Category = "Dinner",
                    Ingredients = new ObservableCollection<Ingredient>
                    {
                        new Ingredient { Name = "Zucchini", Amount = "1", ImageUrl = "zucchini.png" },
                        new Ingredient { Name = "Eggplant", Amount = "1", ImageUrl = "eggplant.png" },
                        new Ingredient { Name = "Tomatoes", Amount = "3", ImageUrl = "tomatoes.png" },
                        new Ingredient { Name = "Garlic", Amount = "3 cloves", ImageUrl = "garlic.png" },
                        new Ingredient { Name = "Olive oil", Amount = "2 tbsp", ImageUrl = "olive_oil.png" }
                    }
                },

                new Recipe
                {
                    Name = "Mexican Guacamole",
                    Author = "Carlos Ramirez",
                    Description = "Creamy avocado dip with lime, cilantro, and tomatoes.",
                    PrepTimeMinutes = 10,
                    Difficulty = "Easy",
                    Calories = 250,
                    Rating = 4.8,
                    ImageUrl = "guacamole.jpg",
                    Category = "Appetizer",
                    Ingredients = new ObservableCollection<Ingredient>
                    {
                        new Ingredient { Name = "Avocados", Amount = "2", ImageUrl = "avocado.png" },
                        new Ingredient { Name = "Lime juice", Amount = "2 tbsp", ImageUrl = "lime.png" },
                        new Ingredient { Name = "Tomatoes", Amount = "1", ImageUrl = "tomatoes.png" },
                        new Ingredient { Name = "Cilantro", Amount = "1 bunch", ImageUrl = "cilantro.png" },
                        new Ingredient { Name = "Salt", Amount = "To taste", ImageUrl = "salt.png" }
                    }
                }
            };
        }

        public ObservableCollection<Category> GetCategories()
        {
            return new ObservableCollection<Category>
            {
                new Category { Name = "Breakfast", Icon = "breakfast_icon.png" },
                new Category { Name = "Lunch", Icon = "lunch_icon.png" },
                new Category { Name = "Dinner", Icon = "dinner_icon.png" },
                new Category { Name = "Dessert", Icon = "dessert_icon.png" }
            };
        }

        public Recipe GetRecipeById(int id)
        {
            var recipes = GetAllRecipes();
            return recipes.FirstOrDefault(r => r.Id == id);
        }
    }
}