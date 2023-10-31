using AndreasReitberger.Shared.Models.Filtering;
using Syncfusion.DataSource;
using System.Collections.Generic;

namespace AndreasReitberger.Shared.Interfaces
{
    public interface IListViewFilterBase
    {
        string Identifier { get; set; }
        List<SortDescriptor> SortDescriptors { get; set; }
        string SearchText { get; set; }
        List<ListViewFilterProperty> SearchedPropertiesList { get; set; }
    }
}
