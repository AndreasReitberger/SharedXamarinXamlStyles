using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace AndreasReitberger.Shared.Themes
{
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DefaultTheme
	{
		public DefaultTheme ()
		{
			InitializeComponent ();
		}
	}
}