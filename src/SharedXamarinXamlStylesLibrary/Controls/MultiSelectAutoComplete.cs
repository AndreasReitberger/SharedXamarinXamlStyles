﻿using Syncfusion.SfAutoComplete.XForms;
using System.Collections;
using Xamarin.Forms;

namespace AndreasReitberger.Shared.XForm.Controls
{
    public class MultiSelectAutoComplete : SfAutoComplete
    {
        public MultiSelectAutoComplete()
        {
            SelectionChanged -= MultiSelectAutoComplete_SelectionChanged;
            SelectionChanged += MultiSelectAutoComplete_SelectionChanged;
        }

        void MultiSelectAutoComplete_SelectionChanged(object sender, Syncfusion.SfAutoComplete.XForms.SelectionChangedEventArgs e)
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
                typeof(MultiSelectAutoComplete),
                new ArrayList(),
                BindingMode.Default,
                null,
                OnSelectionChanged);

        static void OnSelectionChanged(BindableObject bindable, object oldValue, object newValue)
        {
            MultiSelectAutoComplete control = bindable as MultiSelectAutoComplete;
            if (newValue is IList selectedItems)
            {
                control.SetValue(SelectedItemsListProperty, selectedItems);
            }
        }
    }
}
