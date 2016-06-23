using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Toyota_App;
using Windows.ApplicationModel.Search;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TOYOTAcars
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        
        private void btn_showroom_location_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(location));
        }

        private void btn_selectvechile_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(cars_item_page));
        }

        private void btn_home_Click(object sender, RoutedEventArgs e)
        {
           this.Frame.Navigate(typeof(MainPage));
        }

        private void btn_Search_Click(object sender, RoutedEventArgs e)
        {
            SearchPane.GetForCurrentView().QuerySubmitted += MainPage_QuerySubmitted;
            SearchPane.GetForCurrentView().Show();

            SearchPane.GetForCurrentView().SuggestionsRequested += MainPage_SuggestionsRequested;
            SearchPane.GetForCurrentView().Show();

        }

        private void MainPage_SuggestionsRequested(SearchPane sender, SearchPaneSuggestionsRequestedEventArgs args)
        {
            SearchSuggestionCollection coll = args.Request.SearchSuggestionCollection;
            if (args.QueryText.StartsWith("c", StringComparison.CurrentCultureIgnoreCase))
            {
                coll.AppendQuerySuggestion("Carolla");
                coll.AppendQuerySuggestion("Carmy carolla");
                coll.AppendQuerySuggestion("Carmy Highbrid");
                coll.AppendQuerySuggestion("Concept vehicles");
            }
            else if (args.QueryText.StartsWith("4", StringComparison.CurrentCultureIgnoreCase))
            {
                coll.AppendQuerySuggestion("4 Runner");
                coll.AppendQuerySuggestion("Runner Flat");
            }
            else if (args.QueryText.StartsWith("h", StringComparison.CurrentCultureIgnoreCase))
            {
                coll.AppendQuerySuggestion("High Lander");
                coll.AppendQuerySuggestion("High Lander Brid");
            }
            else if (args.QueryText.StartsWith("l", StringComparison.CurrentCultureIgnoreCase))
            {
                coll.AppendQuerySuggestion("Land Cruiser");
                coll.AppendQuerySuggestion("Runner Flat");
            }
            else if (args.QueryText.StartsWith("t", StringComparison.CurrentCultureIgnoreCase))
            {
                coll.AppendQuerySuggestion("Tacoma");
                coll.AppendQuerySuggestion("Tundra");
            }
            else if (args.QueryText.StartsWith("r", StringComparison.CurrentCultureIgnoreCase))
            {
                coll.AppendQuerySuggestion("Rav 4");
            }
            else if (args.QueryText.StartsWith("s", StringComparison.CurrentCultureIgnoreCase))
            {
                coll.AppendQuerySuggestion("Sienna");
                coll.AppendQuerySuggestion("Sequaio");
            }
            else if (args.QueryText.StartsWith("a", StringComparison.CurrentCultureIgnoreCase))
            {
                coll.AppendQuerySuggestion("Avalon");
                coll.AppendQuerySuggestion("Avalon Hybrid");
            }
            else if (args.QueryText.StartsWith("p", StringComparison.CurrentCultureIgnoreCase))
            {
                coll.AppendQuerySuggestion("Prius");
                coll.AppendQuerySuggestion("Prius C");
                coll.AppendQuerySuggestion("Prius V");
            }
            else if (args.QueryText.StartsWith("y", StringComparison.CurrentCultureIgnoreCase))
            {
                coll.AppendQuerySuggestion("Yaris");
                coll.AppendQuerySuggestion("Yaris C");
                coll.AppendQuerySuggestion("Yaris V");
            }
        }

        private void MainPage_QuerySubmitted(SearchPane sender, SearchPaneQuerySubmittedEventArgs args)
        {
            if (args.QueryText == "4 Runner")
            {
                Frame.Navigate(typeof(_4_runner_page));
            }
            else if (args.QueryText == "High Lander")
            {
                Frame.Navigate(typeof(highlander_page));
            }
            else if (args.QueryText == "Tacoma")
            {
                Frame.Navigate(typeof(tacoma_page));
            }
            else if (args.QueryText == "Avalon")
            {
                Frame.Navigate(typeof(avalon_page));
            }
            else if (args.QueryText == "Camry")
            {
                Frame.Navigate(typeof(camry_page));
            }
            else if (args.QueryText == "Carolla")
            {
                Frame.Navigate(typeof(corolla_page));
            }
            else if (args.QueryText == "Tundra")
            {
                Frame.Navigate(typeof(tundra_page));
            }
            else if (args.QueryText == "Sequoia")
            {
                Frame.Navigate(typeof(sequoia_page));
            }
            else if (args.QueryText == "Sienna")
            {
                Frame.Navigate(typeof(sienna_page));
            }
            else if (args.QueryText == "Yaris")
            {
                Frame.Navigate(typeof(yaris_page));
            }
            else if (args.QueryText == "Land Cruiser")
            {
                Frame.Navigate(typeof(Land_cruiser));
            }
            else if (args.QueryText == "Rav4 Hybrid")
            {
                Frame.Navigate(typeof(rav4_hybrid));
            }
        }
        private void txt_learne_more_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(_4_runner_page));
        }
        private void txt_hl_lm_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(highlander_page));
        }

        private void txt_tm_lm_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(tacoma_page));
        }

        private void txt_r4_lm_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(rav4_hybrid));
        }

        private void txt_lc_lm_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Land_cruiser));
        }

        private void camry_pic_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(camry_page));
        }

        private void corolla_pic_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(corolla_page));
        }

        private void rav4_pic_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(rav4_hybrid));
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void feedback_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(feedback));
        }
    }
}

    
