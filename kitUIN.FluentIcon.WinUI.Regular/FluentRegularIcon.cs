using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml;
using System;

namespace FluentIcon.WinUI
{
    public class FluentRegularIcon : FontIcon
    {
        public static readonly DependencyProperty SymbolProperty =
            DependencyProperty.Register(nameof(Symbol),
                typeof(FluentRegularIconSymbol),
                typeof(FluentRegularIcon),
                new PropertyMetadata(default, new PropertyChangedCallback(OnSymbolChanged)));

        public FluentRegularIcon() : base()
        {
            FontFamily = new FontFamily("ms-appx:///Assets/FluentSystemIcons-Regular.ttf#FluentSystemIcons-Regular");
        }
        public FluentRegularIconSymbol Symbol
        {
            get { return (FluentRegularIconSymbol)GetValue(SymbolProperty); }
            set { SetValue(SymbolProperty, value); }
        }

        private static void OnSymbolChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is FluentRegularIconSymbol symbol && d is FluentRegularIcon icon)
            {
                icon.Glyph = char.ConvertFromUtf32((int)symbol);
            }
        }
    }
}
