﻿using Syncfusion.XForms.ComboBox;
using System.Collections;
using SelectionChangedEventArgs = Syncfusion.XForms.ComboBox.SelectionChangedEventArgs;

namespace AndreasReitberger.Shared.XForm.Syncfusion.Controls
{
    public class MultiSelectComboBox : SfComboBox
    {
        public MultiSelectComboBox()
        {
            SelectionChanged += ComboBoxItemSelect_SelectionChanged;

        }

        void ComboBoxItemSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.Value is not IList list)
            {
                // Single item (if token is set to 'none')
                list = new ArrayList
                {
                    e.Value
                };
            }
            SelectedItemsList = list;
        }

        public IList SelectedItemsList
        {
            get => (IList)GetValue(SelectedItemsListProperty);
            set => SetValue(SelectedItemsListProperty, value);
        }

        public static readonly BindableProperty SelectedItemsListProperty =
            BindableProperty.Create(nameof(SelectedItemsList),
                typeof(IList),
                typeof(MultiSelectComboBox),
                new ArrayList(),
                BindingMode.Default,
                null,
                OnSelectionChanged);

        static void OnSelectionChanged(BindableObject bindable, object oldValue, object newValue)
        {
            MultiSelectComboBox? comboBox = bindable as MultiSelectComboBox;
            if (newValue is IList selectedItems)
            {
                comboBox?.SetValue(SelectedItemsListProperty, selectedItems);
            }
        }
    }
}
