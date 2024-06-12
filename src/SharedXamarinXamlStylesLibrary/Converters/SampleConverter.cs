using Xamarin.Forms.Internals;

namespace AndreasReitberger.Shared.XForm.Converters
{
    [Preserve(AllMembers = true)]
    public class SampleConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string text)
                return text == "Available";
            else
                return false;
        }       
        public object? ConvertBack(object? value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
