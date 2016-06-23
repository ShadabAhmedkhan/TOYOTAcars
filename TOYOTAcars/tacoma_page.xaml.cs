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
    public sealed partial class tacoma_page : Page
    {
        public tacoma_page()
        {
            this.InitializeComponent();
        }

        private void btn_selectvechile_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(cars_item_page));
        }

        private void btn_showroom_location_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(location));
        }

        private void white_Tapped(object sender, TappedRoutedEventArgs e)
        {
            tacoma_pic.Source = new BitmapImage(new Uri("ms-appx:///tacoma pics/white.jpg"));
        }

        private void lightgray_Tapped(object sender, TappedRoutedEventArgs e)
        {
            tacoma_pic.Source = new BitmapImage(new Uri("ms-appx:///tacoma pics/lightgray.jpg"));
        }

        private void gray_Tapped(object sender, TappedRoutedEventArgs e)
        {
            tacoma_pic.Source = new BitmapImage(new Uri("ms-appx:///tacoma pics/gray.jpg"));
        }

        private void blue_Tapped(object sender, TappedRoutedEventArgs e)
        {
            tacoma_pic.Source = new BitmapImage(new Uri("ms-appx:///tacoma pics/blue.jpg"));
        }

        private void black_Tapped(object sender, TappedRoutedEventArgs e)
        {
            tacoma_pic.Source = new BitmapImage(new Uri("ms-appx:///tacoma pics/black.jpg"));
        }

        private void darkred_Tapped(object sender, TappedRoutedEventArgs e)
        {
            tacoma_pic.Source = new BitmapImage(new Uri("ms-appx:///tacoma pics/darkred.jpg"));
        }

        private void sand_Tapped(object sender, TappedRoutedEventArgs e)
        {
            tacoma_pic.Source = new BitmapImage(new Uri("ms-appx:///tacoma pics/sand.jpg"));
        }

        private void orange_Tapped(object sender, TappedRoutedEventArgs e)
        {
            tacoma_pic.Source = new BitmapImage(new Uri("ms-appx:///tacoma pics/orange.jpg"));
        }

        private void btn_feedback_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(feedback));
        }

        private void gallery_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(tacoma_picture));
        }

        private void feature_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(tacoma_feature));
        }

        private void btn_home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

    }
}
