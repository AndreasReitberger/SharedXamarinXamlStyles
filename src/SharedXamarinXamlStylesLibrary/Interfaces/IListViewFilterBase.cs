﻿using AndreasReitberger.Shared.XForm.Models.Filtering;
using Syncfusion.DataSource;
using System.Collections.Generic;

namespace AndreasReitberger.Shared.XForm.Interfaces
{
    public interface IListViewFilterBase
    {
        string Identifier { get; set; }
        List<SortDescriptor> SortDescriptors { get; set; }
        string SearchText { get; set; }
        List<ListViewFilterProperty> SearchedPropertiesList { get; set; }
    }
}
