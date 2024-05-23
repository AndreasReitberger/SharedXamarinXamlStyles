# About
This project is a shared style library for Xamarin.Forms applications containing recurring styles for
core controls and for the Syncfusion Xamarin.Forms controls (https://www.syncfusion.com/downloads/xamarin/fbadv).

# Support me
If you want to support me, you can order over following affilate links (I'll get a small share from your purchase from the corresponding store).

- Prusa: http://www.prusa3d.com/#a_aid=AndreasReitberger *
- Jake3D: https://tidd.ly/3x9JOBp * 
- Amazon: https://amzn.to/2Z8PrDu *

(*) Affiliate link
Thank you very much for supporting me!

# Nugets
Get the latest version from nuget.org<br>

| Package                                       | Nuget  | Downloads |
| --------------------------------------------- |:-----:| -------:|
| SharedXamarinXamlStylesLibrary                | [![NuGet](https://img.shields.io/nuget/v/SharedXamarinXamlStylesLibrary.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/SharedXamarinXamlStylesLibrary/)   | [![NuGet](https://img.shields.io/nuget/dt/SharedXamarinXamlStylesLibrary.svg)](https://www.nuget.org/packages/SharedXamarinXamlStylesLibrary)      |
| SharedXamarinXamlStylesLibrary.Syncfusion     | [![NuGet](https://img.shields.io/nuget/v/SharedXamarinXamlStylesLibrary.Syncfusion.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/SharedXamarinXamlStylesLibrary.Syncfusion/)   | [![NuGet](https://img.shields.io/nuget/dt/SharedXamarinXamlStylesLibrary.Syncfusion.svg)](https://www.nuget.org/packages/SharedXamarinXamlStylesLibrary.Syncfusion)      |

# IMPORTANT CHANGE
Since putting all `FontKeys` in a `ResourceDictionary` leads to poor performance of the app, we moved all `FontKeys` to a static class instead.

## Used fonts
All used fonts are available from the `SharedFonts.Fonts` property. 

```csharp
public class SharedFonts
    {
        #region Properties
        public static Dictionary<string, string> Fonts = new()
        {
            { "FontAwesome5Brands.otf", "FontAwesome5Brands" },
            { "FontAwesome5Regular.otf", "FontAwesome5Regular" },
            { "FontAwesome5Solid.otf", "FontAwesome5Solid" },
            { "materialdesignicons-webfont.ttf", "MaterialDesignIcons" },
            { "Montserrat-Bold.ttf", "MontserratBold" },
            { "Montserrat-Medium.ttf", "MontserratMedium" },
            { "Montserrat-Regular.ttf", "MontserratRegular" },
            { "Montserrat-SemiBold.ttf", "MontserratSemiBold" },
            { "UIFontIcons.ttf", "UIFontIcons" },
        };
        #endregion
    }
```

## Usage
This library combines all styles in the `DefaultTheme.xaml`, which can be merged into your `LightTheme.xaml` / `DarkTheme.xaml`.

```xaml
<ResourceDictionary
    x:Class="KlipperRemoteControl.Themes.LightTheme"
    xmlns="http://xamarin.com/schemas/2014/forms"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    
    xmlns:shared="clr-namespace:AndreasReitberger.Shared.XForm.Themes;assembly=SharedXamarinXamlStylesLibrary"
    >
    <ResourceDictionary.MergedDictionaries>
        <!-- Merge the DefaultTheme here -->
        <shared:DefaultTheme/>
    </ResourceDictionary.MergedDictionaries>

    <!-- Your style stuff -->
</ResourceDictionary>
```

Same applies to the DarkTheme.

# Style Keys
Due to a bug in MAUI (or Visual Studio), InteliSense doesn't suggest the style keys if using a nuget.
https://github.com/AndreasReitberger/SharedMauiXamlStyles/issues/43


## BoxView

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.BoxView.Separato            | BoxView             | Core      |

## Button

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.Button.Default              | Button              | Core      |
| Style.Core.ImageButton.Default         | ImageButton         | Core      |
| Style.Core.Button.Icon                 | Button              | Core      |
| Style.Core.Button.Icon.MaterialDesign  | Button              | Core      |
| Style.Core.Button.IconPrimary.MaterialDesign   | Button              | Core      |
| Style.Core.Button.Link                 | Button              | Core      |
| Style.Core.Button.LinkRound            | Button              | Core      |
| Style.Core.Button.IconRound            | Button              | Core      |
| Style.Core.Button.RoundedLong          | Button              | Core      |
| Style.Core.Button.IconRound.MaterialDesign    | Button              | Core      |
| Style.Core.Button.IconRound.EmergencyStop     | Button              | Core      |
| Style.Core.Button.LoginGoogle                 | Button              | Core      |

## CheckBox

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.CheckBox.Default            | CheckBox            | Core      |


## Editor / BorderlessEditor

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.Editor.Default              | Editor              | Core      |
| Style.Core.BorderlessEditor.Default    | BorderlessEditor    | Core      |

## Entry / BorderlessEntry

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.Entry.Default               | Entry               | Core      |

## Frame

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.Frame.Default               | Frame               | Core      |

## Grid / TapAnimationGrid

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.Grid.Default                | Grid                | Core      |
| Style.Core.Grid.Settings               | Grid                | Core      |
| Style.Core.Grid.Warning                | Grid                | Core      |
| Style.Core.Grid.Error                  | Grid                | Core      |
| Style.Core.Grid.Panel                  | Grid                | Core      |
| Style.Core.Grid.Panel.Modal            | Grid                | Core      |
| Style.Core.Grid.ShellTitleView         | Grid                | Core      |
| Style.Core.TapAnimationGrid.Default    | TapAnimationGrid    | Core      |

 
## Label

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.Label.Default               | Label               | Core      |
| Style.Core.Label.Icon                  | Label               | Core      |
| Style.Core.Label.IconSettings.MaterialDesign          | Label               | Core      |
| Style.Core.Label.Icon.MaterialDesign.TextInputLayout  | Label               | Core      |
| Style.Core.Label.Icon.MaterialDesign        | Label               | Core      |
| Style.Core.Label.IconPrimary.MaterialDesign | Label               | Core      |
| Style.Core.Label.Medium                     | Label               | Core      |
| Style.Core.Label.Small                      | Label               | Core      |
| Style.Core.Label.VerySmall                  | Label               | Core      |
| Style.Core.Label.Setup                      | Label               | Core      |
| Style.Core.Label.Link                       | Label               | Core      |
| Style.Core.Label.Primary                    | Label               | Core      |
| Style.Core.Label.PrimaryDark                | Label               | Core      |
| Style.Core.Label.Warning                    | Label               | Core      |
| Style.Core.Label.Error                      | Label               | Core      |
| Style.Core.Label.Shell                      | Label               | Core      |
| Style.Core.Label.Settings                   | Label               | Core      |
| Style.Core.Label.SettingsSmall              | Label               | Core      |
| Style.Core.Label.Headline                   | Label               | Core      |
| Style.Core.Label.HeadlinePrimary            | Label               | Core      |
| Style.Core.Label.TitleView            | Label               | Core      |
| Style.Core.Label.HeadlinePrimaryDark  | Label               | Core      |
| Style.Core.Label.GroupingHeader       | Label               | Core      |
| SwipeTemplateMaterialButtonStyle      | Label               | Core      |
| Style.Core.Span.Icon.MaterialDesign   | Label               | Core      |
| Style.Core.Span.Icon.FontIcons        | Label               | Core      |
| Style.Core.Label.IconSmall.MaterialDesign  | Label               | Core      |


## Page

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.ContentPage.Default         | Page                | Core      |
| Style.Core.ContentPage.Modal           | Page                | Core      |
| Style.Core.ContentPage.Settings        | Page                | Core      |

## Picker

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.Picker.Default              | Picker              | Core      |


## RefreshView

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.RefreshView.Default         | RefreshView         | Core      |


## Shell

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| BaseStyle                              | Element             | Core      |
| Style.Core.Shell.Default               | Shell               | Core      |
| Style.Core.FlyoutItem.Default          | FlyoutItem          | Core      |

## Slider

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfSlider.Default      | Slider              | Core      |

## StackLayout

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.StackLayout.Header          | StackLayout         | Core      |
| Style.Core.StackLayout.Modal           | StackLayout         | Core      |


## Switch

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.Switch.Default              | Switch              | Core      |


## SfAccordion

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfAccordion.Default   | SfAccordion         | Syncfusion|
| Style.Syncfusion.AccordionItem.Default | AccordionItem       | Syncfusion|

## SfAutoComplete

| Key                                    | TargetType             | Library   |
| ---------------------------------------|:----------------------:| ---------:|
| DefaultAutocompleteStyle               | SfAutoComplete         | Syncfusion|
| DefaultMultiSelectAutoCompleteStyle    | MultiSelectAutoComplete| Syncfusion|

## SfBadgeView

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfBadgeView.Default   | SfBadgeView         | Syncfusion|
| Style.Syncfusion.SfBadgeView.Hyperlink | SfBadgeView         | Syncfusion|

## SfBorder

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfBorder.Profile      | SfBorder            | Syncfusion|
| Style.Syncfusion.SfBorder.MenuSeparator| SfBorder            | Syncfusion|
| Style.Syncfusion.SfBorder.PanelCardView| SfBorder            | Syncfusion|
| Style.Syncfusion.SfBorder.MinimalPanelCardView | SfBorder            | Syncfusion|

## SfBusyIndicator

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfBusyIndicator.Default | SfBusyIndicator     | Syncfusion|

## SfButton

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfButton.Default                   | SfButton            | Syncfusion|
| Style.Syncfusion.SfButton.Icon                      | SfButton            | Syncfusion|
| Style.Syncfusion.SfButton.Icon.MaterialDesign       | SfButton            | Syncfusion|
| Style.Syncfusion.SfButton.Link                      | SfButton            | Syncfusion|
| Style.Syncfusion.SfButton.IconRound.Gradient        | SfButton            | Syncfusion|
| Style.Syncfusion.SfButton.RoundedLong               | SfButton            | Syncfusion|
| Style.Syncfusion.SfButton.Setup                     | SfButton            | Syncfusion|
| Style.Syncfusion.SfButton.IconRound.MaterialDesign  | SfButton            | Syncfusion|
| Style.Syncfusion.SfButton.IconRound.EmergencyStop   | SfButton            | Syncfusion|

## SfCardView

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfCardView.Default                   | SfCardView          | Syncfusion|
| Style.Syncfusion.SfCardView.ControlPanel              | SfCardView          | Syncfusion|

## SfChart

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| None...                                | SfChart             | Syncfusion|

## SfCheckBox

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfCheckBox.Default                 | SfCheckBox          | Syncfusion|

## SfChip

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfChip.Default              | SfChip              | Syncfusion|
| Style.Syncfusion.SfChipGroup.Default                | SfChipGroup         | Syncfusion|

## SfCircularProgressBar

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfCircularProgressBar.Default               |SfCircularProgressBar| Syncfusion|
| Style.Syncfusion.SfCircularProgressBar.Half           |SfCircularProgressBar| Syncfusion|

## SfComboBox

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfComboBox.Default                   | SfComboBox          | Syncfusion|
| Style.Syncfusion.SfComboBox.Servers           | SfComboBox          | Syncfusion|
| Style.Syncfusion.SfComboBox.Printers          | SfComboBox          | Syncfusion|
| Style.Syncfusion.MultiSelectComboBox.Default             | MultiSelectComboBox | Syncfusion|

## SfGradientView

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfGradientView.Default                    | SfGradientView      | Syncfusion|

## SfListView

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfListView.Default                 | SfListView          | Syncfusion|

## SfMaskedEntry

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfMaskedEdit.Default              | SfMaskedEntry       | Syncfusion|
| Style.Syncfusion.SfMaskedEdit.Borderless             | SfMaskedEntry       | Syncfusion|

## SfNumericTextBox

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfNumericTextBox.Default           | SfNumericTextBox    | Syncfusion|

## SfNumericUpDown

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfNumericUpDown.Default            | SfNumericUpDown     | Syncfusion|

## SfDatePicker

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfDatePicker.Default               | SfDatePicker        | Syncfusion|

## SfPullToRefresh

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfPullToRefresh.Default            | SfPullToRefresh     | Syncfusion|

## SfRangeSlider

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfRangeSlider.Default              | SfRangeSlider       | Syncfusion|
| Style.Syncfusion.SfRangeSlider.Primary              | SfRangeSlider       | Syncfusion|

## SfRotator

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfRotator.Default                  | SfRotator           | Syncfusion|

## SfSegmentedControl

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfSegmentedControl.Default         | SfSegmentedControl  | Syncfusion|
| Style.Syncfusion.SfSegmentedControl.Printers         | SfSegmentedControl  | Syncfusion|
| Style.Syncfusion.SfSegmentedControl.Profiles         | SfSegmentedControl  | Syncfusion|

## SfSwitch

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfSwitch.Default                   | SfSwitch            | Syncfusion|

## SfTabView

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfTabView.Default                  | SfTabView           | Syncfusion|
| Style.Syncfusion.SfTabItem.Default              | SfTabItem           | Syncfusion|
| Style.Syncfusion.SfTabItem.Child         | SfTabItem           | Syncfusion|
| Style.Syncfusion.SfTabItem.Small         | SfTabItem           | Syncfusion|
| Style.Syncfusion.SfTabItem.Icon.MaterialDesign         | SfTabItem           | Syncfusion|

## SfTextInputLayout

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Syncfusion.SfTextInputLayout.Default          | SfTextInputLayout   | Syncfusion|


# Licenses & Thirdparty
This project uses thirdparty fonts. All licenses can be found in the project folder under Licenses -> LicenseFiles.
It's mandatory to also add those licenses to your final App. In this case you can use the LicenseManager class to get a List of all
used libraries and their licenses.
https://github.com/AndreasReitberger/SharedMauiXamlStyles/tree/main/source/SharedMauiXamlStylesLibrary/SharedMauiXamlStylesLibrary/Licenses/LicenseFiles
