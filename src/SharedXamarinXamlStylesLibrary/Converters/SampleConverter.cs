using Xamarin.Forms.Internals;

namespace AndreasReitberger.Shared.XForm.Converters
{
    [Preserve(AllMembers = true)]
    public class SampleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (string)value == "Available";
        }       
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
