﻿namespace AndreasReitberger.Shared.XForm.Converters
{
    public sealed class UriToStringConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Uri uri = value as Uri;
            if (uri != null)
            {
                string local = uri.OriginalString;
                return local;
            }
            else return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
            //return value is bool visible && !visible;
        }
    }
}
