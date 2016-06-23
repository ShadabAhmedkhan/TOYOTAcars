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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Toyota_App
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class sienna_page : Page
    {
        public sienna_page()
        {
            this.InitializeComponent();
        }

        private void white_Tapped(object sender, TappedRoutedEventArgs e)
        {
         sienna_pic.Source = new BitmapImage(new Uri("ms-appx:///sienna pics/white.jpg"));
        }

        private void white_1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            sienna_pic.Source = new BitmapImage(new Uri("ms-appx:///sienna pics/white2.jpg"));
        }

        private void light_gray_Tapped(object sender, TappedRoutedEventArgs e)
        {
            sienna_pic.Source = new BitmapImage(new Uri("ms-appx:///sienna pics/white.jpg"));
        }

        private void gray_Tapped(object sender, TappedRoutedEventArgs e)
        {
            sienna_pic.Source = new BitmapImage(new Uri("ms-appx:///sienna pics/gray.jpg"));
        }

        private void black_Tapped(object sender, TappedRoutedEventArgs e)
        {
            sienna_pic.Source = new BitmapImage(new Uri("ms-appx:///sienna pics/black.jpg"));
        }

        private void darkgray_Tapped(object sender, TappedRoutedEventArgs e)
        {
            sienna_pic.Source = new BitmapImage(new Uri("ms-appx:///sienna pics/darkgray.jpg"));
        }

        private void dark_red_Tapped(object sender, TappedRoutedEventArgs e)
        {
            sienna_pic.Source = new BitmapImage(new Uri("ms-appx:///sienna pics/darkred.jpg"));
        }

        private void lightblue_Tapped(object sender, TappedRoutedEventArgs e)
        {
            sienna_pic.Source = new BitmapImage(new Uri("ms-appx:///sienna pics/lightblue.jpg"));
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

        private void btn_feedback_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(feedback));
        }

        private void gallery_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(sienna_gallery));
        }

        private void feature_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(sienna_feature));
        }
    }
}
