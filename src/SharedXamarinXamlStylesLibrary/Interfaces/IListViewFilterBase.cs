using Syncfusion.DataSource;

namespace AndreasReitberger.Shared.XForm.Interfaces
{
    public interface IListViewFilterBase
    {
        #region Properties
        public Guid Id { get; set; }
        public string Identifier { get; set; }
        public List<SortDescriptor> SortDescriptors { get; set; }
        public string SearchText { get; set; }
        public List<IListViewFilterProperty> SearchedPropertiesList { get; set; }

        #endregion
    }
}
