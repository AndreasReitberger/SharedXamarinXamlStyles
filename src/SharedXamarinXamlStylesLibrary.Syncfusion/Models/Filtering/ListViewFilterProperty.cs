using AndreasReitberger.Shared.XForm.Syncfusion.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AndreasReitberger.Shared.XForm.Syncfusion.Filtering
{
    public partial class ListViewFilterProperty : ObservableObject, IListViewFilterProperty
    {
        #region Properties
        [ObservableProperty]
        public partial string LocalisedName { get; set; } = string.Empty;

        [ObservableProperty]
        public partial string Property { get; set; } = string.Empty;
        #endregion

        #region overrides
        public override string ToString() => LocalisedName;
        
        public override bool Equals(object obj)
        {
            if (obj is not ListViewFilterProperty item)
                return false;
            return Property.Equals(item.Property);
        }
        public override int GetHashCode() => Property.GetHashCode();
        
        #endregion
    }
}
