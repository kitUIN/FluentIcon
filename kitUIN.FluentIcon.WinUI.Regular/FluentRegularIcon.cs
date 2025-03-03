using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml;

namespace FluentIcon.WinUI;
/// <summary>
/// FluentIcon-Regular
/// </summary>
public class FluentRegularIcon : FontIcon
{
    public static readonly DependencyProperty SymbolProperty =
        DependencyProperty.Register(nameof(Symbol),
            typeof(FluentRegularIconSymbol),
            typeof(FluentRegularIcon),
            new PropertyMetadata(default, new PropertyChangedCallback(OnSymbolChanged)));
    /// <summary>
    /// 
    /// </summary>
    public static readonly DependencyProperty AutoFontSizeProperty =
        DependencyProperty.Register(nameof(AutoFontSize), typeof(double), typeof(FluentRegularIcon),
            new PropertyMetadata(20.0, OnAutoFontSizeChanged));

    public double AutoFontSize
    {
        get => (double)GetValue(AutoFontSizeProperty);
        set => SetValue(AutoFontSizeProperty, value);
    }

    private static void OnAutoFontSizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is not FluentRegularIcon icon) return;
        var newSize = (double)e.NewValue;
        icon.FontSize = newSize + 3;
    }
    public FluentRegularIcon() : base()
    {
        FontFamily = new FontFamily("ms-appx:///Assets/FluentSystemIcons-Regular.ttf#FluentSystemIcons-Regular");
        RenderTransform = new TranslateTransform { Y = 1 }; // 下沉1像素
    }
    public FluentRegularIconSymbol Symbol
    {
        get => (FluentRegularIconSymbol)GetValue(SymbolProperty);
        set => SetValue(SymbolProperty, value);
    }

    private static void OnSymbolChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (e.NewValue is FluentRegularIconSymbol symbol && d is FluentRegularIcon icon)
        {
            icon.Glyph = char.ConvertFromUtf32((int)symbol);
        }
    }
}