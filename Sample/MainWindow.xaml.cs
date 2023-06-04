using FluntIcon;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Sample
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public ObservableCollection<FluentIconSymbolTest> fluentIcons = new ObservableCollection<FluentIconSymbolTest>();
        public MainWindow()
        {
            this.InitializeComponent();
            
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach(FluentIconSymbolTest icon in e.AddedItems)
            {
                ShowIcon.Symbol = icon.Symbol;
                ShowIconName.Text = icon.Name;
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (FluentIconSymbol en in Enum.GetValues(typeof(FluentIconSymbol)))
            {
                fluentIcons.Add(new FluentIconSymbolTest(en));
            }
        }
    }
}
