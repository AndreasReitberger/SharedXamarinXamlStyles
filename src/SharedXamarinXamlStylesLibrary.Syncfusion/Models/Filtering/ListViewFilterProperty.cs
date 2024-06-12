using AndreasReitberger.Shared.XForm.Syncfusion.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AndreasReitberger.Shared.XForm.Syncfusion.Filtering
{
    public partial class ListViewFilterProperty : ObservableObject, IListViewFilterProperty
    {
        #region Properties
        [ObservableProperty]
        string localisedName = string.Empty;

        [ObservableProperty]
        string property = string.Empty;
        #endregion

        #region overrides
        public override string ToString()
        {
            return LocalisedName;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is ListViewFilterProperty item))
                return false;
            return Property.Equals(item.Property);
        }
        public override int GetHashCode()
        {
            return Property.GetHashCode();
        }
        #endregion
    }
}
