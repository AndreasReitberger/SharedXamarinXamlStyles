using Syncfusion.XForms.Buttons;
using System.Collections.ObjectModel;

namespace AndreasReitberger.Shared.XForm.Syncfusion.Converters
{
    public sealed class ColorToChipConverter : IValueConverter
    {
        SfChip selectedChip = null;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ObservableCollection<SfChip> colorChips = new();
            foreach (Color item in value as ObservableCollection<Color>)
            {
                SfChip colorChip = new()
                {
                    BackgroundColor = (Color)item,
                    ShowSelectionIndicator = true,
                    SelectionIndicatorColor = Color.Transparent,
                    CornerRadius = 20,
                    WidthRequest = 40,
                    HeightRequest = 40,
                    Margin = 10,
                    BorderWidth = 1
                };
                colorChip.BorderColor = Color.FromRgb(-(colorChip.BackgroundColor.R - 1), -(colorChip.BackgroundColor.G - 1), -(colorChip.BackgroundColor.B - 1));
                double mean = (colorChip.BackgroundColor.R + colorChip.BackgroundColor.G + colorChip.BackgroundColor.B) / 3;
                colorChip.BorderColor = mean < 0.5 ? Color.White : Color.Black;
                colorChips.Add(colorChip);
            }
            return colorChips;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        void ColorChip_Clicked(object sender, EventArgs e)
        {
            if (selectedChip != null)
            {
                selectedChip.ShowSelectionIndicator = false;
                selectedChip.BorderWidth = 1;
            }
            selectedChip = (sender as SfChip);
            selectedChip.ShowSelectionIndicator = true;
            selectedChip.SelectionIndicatorColor = selectedChip.BorderColor;
            selectedChip.BorderWidth = 3;
        }
    }
}
