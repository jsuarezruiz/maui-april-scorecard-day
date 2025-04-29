using System.Globalization;

namespace Cookpedia.Converters
{
    public class CategoryColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string categoryName)
            {
                return categoryName switch
                {
                    "Breakfast" => Color.FromArgb("#E3F2FD"),
                    "Lunch" => Color.FromArgb("#FFF3E0"),
                    "Dinner" => Color.FromArgb("#F9FBE7"),
                    "Dessert" => Color.FromArgb("#F3E5F5"),
                    _ => Color.FromArgb("#F5F5F5")
                };
            }
            return Color.FromArgb("#F5F5F5");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
