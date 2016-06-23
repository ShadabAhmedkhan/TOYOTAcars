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
    public sealed partial class upcoming : Page
    {
        public upcoming()
        {
            this.InitializeComponent();
        }

        private void tacoma_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(tacoma_TRD));
        }

        private void comingcar_Tapped(object sender, TappedRoutedEventArgs e)
        {
           this.Frame.Navigate(typeof(concept_2015_Ft1));
        }

        private void btn_car_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(cars_item_page));
        }

        private void btn_truck_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(truck));
        }

        private void btn_upcoming_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upcoming));
        }

        private void btn_crossover_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(crossover_and_suvs));
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
    }
}
