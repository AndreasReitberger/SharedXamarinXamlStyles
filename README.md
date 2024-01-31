# About
This project is a shared style library for Xamarin.Forms applications containing recurring styles for
core controls and for the Syncfusion Xamarin.Forms controls (https://www.syncfusion.com/downloads/xamarin/fbadv).

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
| Style.Core.BoxView.Separator                         | BoxView             | Core      |

## Button

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.Button.Default                     | Button              | Core      |
| ImageButton                            | Button              | Core      |
| IconButtonStyle                        | Button              | Core      |
| Style.Core.Button.Icon.MaterialDesign          | Button              | Core      |
| Style.Core.Button.IconPrimary.MaterialDesign   | Button              | Core      |
| Style.Core.Button.Link                        | Button              | Core      |
| Style.Core.Button.LinkRound                   | Button              | Core      |
| RoundIconButtonStyle                   | Button              | Core      |
| Style.Core.Button.RoundedLong                 | Button              | Core      |
| SwipeTemplateBorderStyle               | Button              | Core      |
| SwipeTemplateButtonStyle               | Button              | Core      |
| Style.Core.Button.IconRound.MaterialDesign     | Button              | Core      |
| "Style.Core.Button.IconRound.EmergencyStop      | Button              | Core      |
| Style.Core.Button.LoginGoogle                 | Button              | Core      |

## CheckBox

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| Style.Core.CheckBox.Default                   | CheckBox            | Core      |


## Editor / BorderlessEditor

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultEditorStyle                     | Editor              | Core      |
| DefaultBorderlessEditorStyle           | BorderlessEditor    | Core      |

## Entry / BorderlessEntry

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultEntryStyle                      | Entry               | Core      |
| NumericEntryStyle                      | Entry               | Core      |
| PasswordEntryStyle                     | Entry               | Core      |

## Frame

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultFrameStyle                      | Frame               | Core      |
| ListViewItemFrameStyle                 | Frame               | Core      |

## Grid / TapAnimationGrid

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultGridStyle                       | Grid                | Core      |
| DefaultSettingsGridStyle               | Grid                | Core      |
| WarningGridStyle                       | Grid                | Core      |
| CriticalErrorGridStyle                 | Grid                | Core      |
| DefaultPanelGridStyle                  | Grid                | Core      |
| ModalPanelGridStyle                    | Grid                | Core      |
| ShellTitleViewGridStyle                | Grid                | Core      |
| DefaultTapAnimationGridStyle           | TapAnimationGrid    | Core      |

 
## Label

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultLabelStyle                      | Label               | Core      |
| LabelStyle                             | Label               | Core      |
| IconLabelStyle                         | Label               | Core      |
| MaterialSettingsIconLabelStyle         | Label               | Core      |
| TextInputLayoutMaterialIconLabelStyle  | Label               | Core      |
| MaterialFontFamilyIconLabelStyle       | Label               | Core      |
| PrimaryMaterialFontFamilyIconLabelStyle| Label               | Core      |
| MediumLabelStyle                       | Label               | Core      |
| SmallLabelStyle                        | Label               | Core      |
| VerySmallLabelStyle                    | Label               | Core      |
| SetupLabelStyle                        | Label               | Core      |
| LinkLabelStyle                         | Label               | Core      |
| PrimaryLabelStyle                      | Label               | Core      |
| PrimaryDarkLabelStyle                  | Label               | Core      |
| WarningLabelStyle                      | Label               | Core      |
| ErrorLabelStyle                        | Label               | Core      |
| ShellLabelStyle                        | Label               | Core      |
| SettingsLabelStyle                     | Label               | Core      |
| SettingsSmallLabelStyle                | Label               | Core      |
| HeadlineLabelStyle                     | Label               | Core      |
| PrimaryHeadlineLabelStyle              | Label               | Core      |
| TitleViewHeadlineLabelStyle            | Label               | Core      |
| PrimaryDarkHeadlineLabelStyle          | Label               | Core      |
| SwipeTemplateButtonStyle               | Label               | Core      |
| OptionButtonLabelStyle                 | Label               | Core      |
| GroupingHeaderLabelStyle               | Label               | Core      |
| SwipeTemplateMaterialButtonStyle       | Label               | Core      |
| MaterialFontIconSpanStyle              | Label               | Core      |
| FontIconSpanStyle                      | Label               | Core      |
| MaterialFontFamilyIconSmallLabelStyle  | Label               | Core      |
| MaterialSwipeTemplateButtonStyle       | Label               | Core      |


## Page

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultPageStyle                       | Page                | Core      |
| ModalPageStyle                         | Page                | Core      |
| SettingsPageStyle                      | Page                | Core      |

## Picker

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultPickerStyle                     | Picker              | Core      |


## RefreshView

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultRefreshViewStyle                | RefreshView         | Core      |


## Shell

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| BaseStyle                              | Element             | Core      |
| DefaultShellStyle                      | Shell               | Core      |
| DefaultFlyoutItemStyle                 | FlyoutItem          | Core      |

## Slider

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSliderStyle                     | Slider              | Core      |

## StackLayout

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| StackLayoutHeaderStyle                 | StackLayout         | Core      |
| ModalInputPageStackLayoutStyle         | StackLayout         | Core      |


## Switch

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSwitchStyle                     | Switch              | Core      |


## SfAccordion

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultAccordionStyle                  | SfAccordion         | Syncfusion|
| DefaultAccordionItemStyle              | AccordionItem       | Syncfusion|

## SfAutoComplete

| Key                                    | TargetType             | Library   |
| ---------------------------------------|:----------------------:| ---------:|
| DefaultAutocompleteStyle               | SfAutoComplete         | Syncfusion|
| DefaultMultiSelectAutoCompleteStyle    | MultiSelectAutoComplete| Syncfusion|

## SfBadgeView

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultBadgeViewStyle                  | SfBadgeView         | Syncfusion|
| HyperlinkBadgedViewStyle               | SfBadgeView         | Syncfusion|

## SfBorder

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| ProfileSfBorderStyle                   | SfBorder            | Syncfusion|
| MenuSeparatorSfBorderStyle             | SfBorder            | Syncfusion|
| PanelCardViewSfBorderStyle             | SfBorder            | Syncfusion|
| MinimalPanelCardViewSfBorderStyle      | SfBorder            | Syncfusion|

## SfBusyIndicator

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultBusyIndicatorStyle              | SfBusyIndicator     | Syncfusion|

## SfButton

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSfButtonStyle                   | SfButton            | Syncfusion|
| IconSfButtonStyle                      | SfButton            | Syncfusion|
| MaterialDesignIconSfButtonStyle        | SfButton            | Syncfusion|
| LinkSfButtonStyle                      | SfButton            | Syncfusion|
| RoundIconGradientSfButtonStyle         | SfButton            | Syncfusion|
| RoundedLongSfButtonStyle               | SfButton            | Syncfusion|
| SetupSfButtonStyle                     | SfButton            | Syncfusion|
| SwipeTemplateSfButtonStyle             | SfButton            | Syncfusion|
| RoundMaterialDesignIconSfButtonStyle   | SfButton            | Syncfusion|
| RoundEmergencyStopIconSfButtonStyle    | SfButton            | Syncfusion|

## SfCardView

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultCardViewStyle                   | SfCardView          | Syncfusion|
| ControlPanelCardViewStyle              | SfCardView          | Syncfusion|

## SfChart

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| None...                                | SfChart             | Syncfusion|

## SfCheckBox

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSfCheckBoxStyle                 | SfCheckBox          | Syncfusion|

## SfChip

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| ColorSelectionSfChipStyle              | SfChip              | Syncfusion|
| DefaultSfChipGroupStyle                | SfChipGroup         | Syncfusion|

## SfCircularProgressBar

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| CircularProgressBarStyle               |SfCircularProgressBar| Syncfusion|
| HalfCircularProgressBarStyle           |SfCircularProgressBar| Syncfusion|

## SfComboBox

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultComboBoxStyle                   | SfComboBox          | Syncfusion|
| ServerSelectionComboBoxStyle           | SfComboBox          | Syncfusion|
| PrinterSelectionComboBoxStyle          | SfComboBox          | Syncfusion|
| DefaultMultiSelectComboBox             | MultiSelectComboBox | Syncfusion|

## SfGradientView

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| SfGradientViewStyle                    | SfGradientView      | Syncfusion|

## SfListView

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSfListViewStyle                 | SfListView          | Syncfusion|

## SfMaskedEntry

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSfMaskedEntryStyle              | SfMaskedEntry       | Syncfusion|
| BorderlessMaskedEntryStyle             | SfMaskedEntry       | Syncfusion|

## SfNumericTextBox

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSfNumericTextBoxStyle           | SfNumericTextBox    | Syncfusion|

## SfNumericUpDown

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSfNumericUpDownStyle            | SfNumericUpDown     | Syncfusion|

## SfDatePicker

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSfDatePickerStyle               | SfDatePicker        | Syncfusion|

## SfPullToRefresh

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSfPullToRefreshStyle            | SfPullToRefresh     | Syncfusion|

## SfRangeSlider

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSfRangeSliderStyle              | SfRangeSlider       | Syncfusion|
| PrimraySfRangeSliderStyle              | SfRangeSlider       | Syncfusion|

## SfRotator

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSfRotatorStyle                  | SfRotator           | Syncfusion|

## SfSegmentedControl

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSfSegmentedControlStyle         | SfSegmentedControl  | Syncfusion|
| PrinterSfSegmentedControlStyle         | SfSegmentedControl  | Syncfusion|
| ProfileSfSegmentedControlStyle         | SfSegmentedControl  | Syncfusion|

## SfSwitch

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSfSwitchStyle                   | SfSwitch            | Syncfusion|

## SfTabView

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSfTabViewStyle                  | SfTabView           | Syncfusion|
| DefaultSfTabViewItemStyle              | SfTabItem           | Syncfusion|
| ChildSfTabViewItemDefaultStyle         | SfTabItem           | Syncfusion|
| SmallSfTabViewItemDefaultStyle         | SfTabItem           | Syncfusion|
| MaterialIconSfTabViewItemStyle         | SfTabItem           | Syncfusion|

## SfTextInputLayout

| Key                                    | TargetType          | Library   |
| ---------------------------------------|:-------------------:| ---------:|
| DefaultSfTextInputLayoutStyle          | SfTextInputLayout   | Syncfusion|


# Licenses & Thirdparty
This project uses thirdparty fonts. All licenses can be found in the project folder under Licenses -> LicenseFiles.
It's mandatory to also add those licenses to your final App. In this case you can use the LicenseManager class to get a List of all
used libraries and their licenses.
https://github.com/AndreasReitberger/SharedMauiXamlStyles/tree/main/source/SharedMauiXamlStylesLibrary/SharedMauiXamlStylesLibrary/Licenses/LicenseFiles
