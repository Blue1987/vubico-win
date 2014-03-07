using System;
using System.Windows;
using Microsoft.Phone.Controls;

namespace sdkMiniBrowserCS
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Go button clicked event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
     /*   private void button1_Click(object sender, RoutedEventArgs e)
        {
            string site;
            site = textBox1.Text;
            webBrowser1.Navigate(new Uri(site, UriKind.Absolute));
           
        }*/

        private void WebBrowser_OnLoaded(object sender, RoutedEventArgs e)
        {
            webBrowser1.Navigate(new Uri("https://vubi.co/"));
            webBrowser1.Navigating += OnNavigating;
        }

        private void OnNavigating(object sender, NavigatingEventArgs e)
        {
            //every navigation to any sites that is not https://vubi.co will be block
            if (e.Uri.OriginalString != "https://vubi.co")
            {
                e.Cancel = true;
            }
        }
      
    }
}
