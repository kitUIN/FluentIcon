using FluntIcon;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentIcon
{
    /// <summary>
    /// FontIcon From fluentui-system-icons(Github)
    /// </summary>
    public class FluentIcon: FontIcon
    {
        public static readonly DependencyProperty SymbolProperty =
            DependencyProperty.Register(nameof(Symbol),
                typeof(FluentIconSymbol),
                typeof(FontIcon),
                new PropertyMetadata(default, new PropertyChangedCallback(OnSymbolChanged)));

        public FluentIcon(): base()
        {
            FontFamily = new Microsoft.UI.Xaml.Media.FontFamily("ms-appx:///Assets/FluentSystemIcons-Resizable.ttf#FluentSystemIcons-Resizable");
        }
        public FluentIconSymbol Symbol
        {
            get { return (FluentIconSymbol)GetValue(SymbolProperty); }
            set { SetValue(SymbolProperty, value); }
        }

        private static void OnSymbolChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue is FluentIconSymbol symbol && d is FluentIcon icon)
            {
                icon.Glyph = ((char)symbol).ToString();
            }
        }
    }
}
