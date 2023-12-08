using AndreasReitberger.Shared.XForm.Core.Theme;
using Xamarin.Forms;
using Xamarin.Essentials;

//[assembly: InternalsVisibleTo("AndreasReitberger.Shared.Syncfusion")]
namespace AndreasReitberger.Shared.XForm.Interfaces
{
    public interface IThemeManager
    {
        #region Properties
        public OSAppTheme Theme { get; }
        #endregion

        #region Methods
        //ResourceDictionary GetThemeResources(AppTheme theme);
        public void ApplyTheme(OSAppTheme theme, Application app);
        public void UpdatePrimaryThemeColor(ThemeColorInfo theme, Application app);
        #endregion
    }
}
