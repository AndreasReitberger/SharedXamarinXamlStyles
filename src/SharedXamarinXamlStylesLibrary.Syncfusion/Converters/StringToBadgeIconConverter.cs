using Syncfusion.XForms.BadgeView;
using Xamarin.Forms.Internals;

namespace AndreasReitberger.Shared.XForm.Syncfusion.Converters
{
    [Preserve(AllMembers = true)]
    public class StringToBadgeIconConverter : IValueConverter
    {
        /// <summary>
        /// This method is used to convert the string to badge icon.
        /// </summary>
        /// <param name="value">Gets the value.</param>
        /// <param name="targetType">Gets the target type.</param>
        /// <param name="parameter">Gets the parameter.</param>
        /// <param name="culture">Gets the culture.</param>
        /// <returns>Return the badge icon.</returns>
        public object? Convert(object? value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string icon)
                return icon == "Available" ? BadgeIcon.Dot : BadgeIcon.None;
            return BadgeIcon.None;
        }

        /// <summary>
        /// This method is used to convert the color to badge icon.
        /// </summary>
        /// <param name="value">Gets the value.</param>
        /// <param name="targetType">Gets the target type.</param>
        /// <param name="parameter">Gets the parameter.</param>
        /// <param name="culture">Gets the culture.</param>
        /// <returns>Returns null.</returns>        
        public object? ConvertBack(object? value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
