using FluentIcon.WinUI;
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
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
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
        public ObservableCollection< FluentIconSymbolTest>  fluentIcons = new ObservableCollection<FluentIconSymbolTest>();
        private bool isQuery = false;
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
                TopBlock.Text = "\"xmlns:icons=\"using: FluentRegularIcon\"";
                GlyphBlock.Text = icon.Glyph;
                XamlBlock.Text = $"<icons: FluentRegularIcon Symbol=\"{icon.Symbol}\" />";
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            foreach ( FluentRegularIconSymbol en in Enum.GetValues(typeof( FluentRegularIconSymbol)))
            {
                fluentIcons.Add(new FluentIconSymbolTest(en));
            }
        }

        private void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if(args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                string text = sender.Text.ToLower();
                if(text.Length >=2 && text[..2] == "\\u")
                {
                    Debug.WriteLine("Glyph " + text);
                    SearchBox.ItemsSource = fluentIcons
                    .AsParallel()
                    .Where(x => x.Glyph.ToLower().Contains(text))
                    .ToList();
                }
                else
                {
                    Debug.WriteLine("Name " + text);
                    SearchBox.ItemsSource = fluentIcons
                    .AsParallel()
                    .Where(x => x.Name.ToLower().Contains(text))
                    .ToList();
                }
            }
        }

        private void AutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            isQuery = true;
            if (args.ChosenSuggestion is FluentIconSymbolTest icon)
            {
                ShowIcon.Symbol = icon.Symbol;
                ShowIconName.Text = icon.Name;
                TopBlock.Text = "\"xmlns:icons=\"using: FluentIcon.WinUI\"";
                GlyphBlock.Text = icon.Glyph;
                XamlBlock.Text = $"<icons: FluentRegularIcon Symbol=\"{icon.Symbol}\" />";
            }
            else
            {
                if (fluentIcons.FirstOrDefault(x => x.Name.ToLower() == sender.Text.ToLower()) is  FluentIconSymbolTest symbol)
                {
                    ShowIcon.Symbol = symbol.Symbol;
                    ShowIconName.Text = symbol.Name;
                    TopBlock.Text = "\"xmlns:icons=\"using: FluentIcon.WinUI\"";
                    GlyphBlock.Text = symbol.Glyph;
                    XamlBlock.Text = $"<icons: FluentRegularIcon Symbol=\"{symbol.Symbol}\" />";
                }
            }
        }

        private void AutoSuggestBox_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {
            isQuery = false;
            sender.Text = ((FluentIconSymbolTest)args.SelectedItem).Name;
        }

        private void  FluentRegularIcon_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
