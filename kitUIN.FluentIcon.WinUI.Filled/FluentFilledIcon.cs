using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml;
namespace FluentIcon.WinUI;
/// <summary>
/// FluentIcon-Filled
/// </summary>
public class FluentFilledIcon : FontIcon
{
    /// <summary>
    /// 
    /// </summary>
    public static readonly DependencyProperty SymbolProperty =
        DependencyProperty.Register(nameof(Symbol),
            typeof(FluentFilledIconSymbol),
            typeof(FluentFilledIcon),
            new PropertyMetadata(null, OnSymbolChanged));
    /// <summary>
    /// 
    /// </summary>
    public static readonly DependencyProperty AutoFontSizeProperty =
        DependencyProperty.Register(nameof(AutoFontSize), typeof(double), typeof(FluentFilledIcon),
            new PropertyMetadata(20.0, OnAutoFontSizeChanged));

    public double AutoFontSize
    {
        get => (double)GetValue(AutoFontSizeProperty);
        set => SetValue(AutoFontSizeProperty, value);
    }

    private static void OnAutoFontSizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is not FluentFilledIcon icon) return;
        var newSize = (double)e.NewValue;
        icon.FontSize = newSize + 3;
    }
    public FluentFilledIcon() : base()
    {
        FontFamily = new FontFamily("ms-appx:///Assets/FluentSystemIcons-Filled.ttf#FluentSystemIcons-Filled");
        RenderTransform = new TranslateTransform { Y = 1 }; // 下沉1像素
    }
    public FluentFilledIconSymbol Symbol
    {
        get => (FluentFilledIconSymbol)GetValue(SymbolProperty);
        set => SetValue(SymbolProperty, value);
    }

    private static void OnSymbolChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (e.NewValue is FluentFilledIconSymbol symbol && d is FluentFilledIcon icon)
        {
            icon.Glyph = char.ConvertFromUtf32((int)symbol);
        }
    }
}