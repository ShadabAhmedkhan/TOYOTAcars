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
    public sealed partial class _4_runner_page : Page
    {
        public _4_runner_page()
        {
            this.InitializeComponent();
        }

        private void gray_Tapped(object sender, TappedRoutedEventArgs e)
        {
            runner_pic.Source = new BitmapImage(new Uri("ms-appx:///4_runner pics/darkgray.jpg"));
        }

        private void light_gray_Tapped(object sender, TappedRoutedEventArgs e)
        {
            runner_pic.Source = new BitmapImage(new Uri("ms-appx:///4_runner pics/white2.jpg"));
        }

        private void white_1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            runner_pic.Source = new BitmapImage(new Uri("ms-appx:///4_runner pics/white1.jpg"));
        }

        private void white_Tapped(object sender, TappedRoutedEventArgs e)
        {
            runner_pic.Source = new BitmapImage(new Uri("ms-appx:///4_runner pics/white.jpg"));
        }

        private void black_Tapped(object sender, TappedRoutedEventArgs e)
        {
            runner_pic.Source = new BitmapImage(new Uri("ms-appx:///4_runner pics/black.jpg"));
        }

        private void navy_Tapped(object sender, TappedRoutedEventArgs e)
        {
            runner_pic.Source = new BitmapImage(new Uri("ms-appx:///4_runner pics/navy.jpg"));
        }

        private void dark_red_Tapped(object sender, TappedRoutedEventArgs e)
        {
            runner_pic.Source = new BitmapImage(new Uri("ms-appx:///4_runner pics/darkred.jpg"));
        }

        private void sand_Tapped(object sender, TappedRoutedEventArgs e)
        {
            runner_pic.Source = new BitmapImage(new Uri("ms-appx:///4_runner pics/sand.jpg"));
        }

        private void btn_selectvechile_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void btn_showroom_location_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(cars_item_page));
        }

        private void gallery_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(runner_picture));
        }

        private void feature_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(runner_feature));
        }

        private void btn_feedback_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(feedback));
        }

        private void home_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
