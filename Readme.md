<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DevExpress.Examples.ThemeSwitcher/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DevExpress.Examples.ThemeSwitcher/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DevExpress.Examples.ThemeSwitcher/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DevExpress.Examples.ThemeSwitcher/MainWindow.xaml.vb))
* [Task.cs](./CS/DevExpress.Examples.ThemeSwitcher/Task.cs) (VB: [Task.vb](./VB/DevExpress.Examples.ThemeSwitcher/Task.vb))
<!-- default file list end -->
# How to use DevExpress themes in a WPF Application


<p>This example demonstrates all common ways of using themes in your application.</p>
<p>DevExpress provides multiple themes that can be applied to all DevExpress WPF controls and some standard controls (GroupBox, ScrollViewer, Scroll, RadioButton, Button, ListBox, Slider, TabControl, Separator, ToggleButton, RepeatButton, Label, ListBoxItem, TabItem, ToolTip, etc.). All built-in themes are described in the following article: <a href="http://documentation.devexpress.com/#WPF/CustomDocument7407">DevExpress WPF Themes</a>.</p>
<p><br>The easiest way to apply a particular theme to the application is to specify the static <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXpfCoreApplicationThemeHelper_ApplicationThemeNametopic">ApplicationThemeHelper.ApplicationThemeName</a> property.</p>
<p><strong>Note:</strong><br>In versions prior to v16.1, use the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfCoreThemeManager_ApplicationThemeNametopic">ThemeManager.ApplicationThemeName</a> property.</p>
<p><br>To set a theme for a specific element, use the <strong>ThemeManager.ThemeName</strong> attached property:</p>
<p> </p>


```xaml
xmlns:dx=”<a href="http://schemas.devexpress.com/winfx/2008/xaml/core&rdquo">http://schemas.devexpress.com/winfx/2008/xaml/core&rdquo</a>;

<TextBox Name="textBox1" dx:ThemeManager.ThemeName="MetropolisLight" Width="120" Height="23"/>
```


<p> </p>
<p>In this case, the theme will be applied to the element and all its child elements.</p>
<p>Keep in mind these simple rules when applying DevExpress themes:</p>
<p>1. The <strong>ApplicationThemeHelper.ApplicationThemeName</strong> property has lower priority than the <strong>ThemeManager.ThemeName</strong> property set locally.</p>
<p>2. The <strong>ThemeManager.ThemeName</strong> property value set for a parent element may be changed for its child if you explicitly specify the <strong>ThemeManager.ThemeName</strong> property for it.</p>
<p>In some cases, you may need to retrieve a list of all available DevExpress themes. The static <strong>Theme.Themes</strong> property contains this information.</p>
<p> <br><strong>See Also:</strong><br><a href="https://www.devexpress.com/Support/Center/p/T361488">How to find and change an inner DevExpress control template</a><br><a href="https://www.devexpress.com/Support/Center/p/K18542">K18542 - How to implement the ThemeMananger theme support in custom controls</a><br><a href="https://www.devexpress.com/Support/Center/p/T207471">T207471 - How to use the ThemeResource extension to load resources from DevExpress themes dynamically</a></p>

<br/>


