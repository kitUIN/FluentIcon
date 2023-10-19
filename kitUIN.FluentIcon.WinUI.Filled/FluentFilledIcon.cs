using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml;
namespace FluentIcon.WinUI
{
    public class FluentFilledIcon : FontIcon
    {
        public static readonly DependencyProperty SymbolProperty =
            DependencyProperty.Register(nameof(Symbol),
                typeof(FluentFilledIconSymbol),
                typeof(FluentFilledIcon),
                new PropertyMetadata(default, new PropertyChangedCallback(OnSymbolChanged)));

        public FluentFilledIcon() : base()
        {
            FontFamily = new FontFamily("ms-appx:///Assets/FluentSystemIcons-Filled.ttf#FluentSystemIcons-Filled");
        }
        public FluentFilledIconSymbol Symbol
        {
            get { return (FluentFilledIconSymbol)GetValue(SymbolProperty); }
            set { SetValue(SymbolProperty, value); }
        }

        private static void OnSymbolChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is FluentFilledIconSymbol symbol && d is FluentFilledIcon icon)
            {
                icon.Glyph = char.ConvertFromUtf32((int)symbol);
            }
        }
    }
}
