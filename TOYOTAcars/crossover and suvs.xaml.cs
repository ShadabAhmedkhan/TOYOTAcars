using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TOYOTAcars;
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

namespace Toyota_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class crossover_and_suvs : Page
    {
        public crossover_and_suvs()
        {
            this.InitializeComponent();
        }

        private void btn_car_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(cars_item_page));
        }

        private void rev_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(rav4_hybrid));
        }

        private void highlander_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(highlander_page));
        }

        private void runner_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(_4_runner_page));
        }

        private void land_crussier_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Land_cruiser));
        }

        private void btn_truck_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(truck));
        }

        private void btn_crossover_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(crossover_and_suvs));
        }

        private void btn_upcoming_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upcoming));
        }

        private void btn_home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void btn_selectvechile_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(cars_item_page));
        }

        private void btn_showroom_location_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(location));
        }

        private void feedback_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(feedback));
        }

        private void sequoia_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(sequoia_page));
        }

    }
}
