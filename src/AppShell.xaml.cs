using Cookpedia.Views;

namespace Cookpedia
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(HomeView), typeof(HomeView));
            Routing.RegisterRoute("recipedetails", typeof(RecipeDetailsView));
            Routing.RegisterRoute(nameof(BookmarkView), typeof(BookmarkView));
        }
    }
}