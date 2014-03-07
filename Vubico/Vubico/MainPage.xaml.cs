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
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string site;
            site = textBox1.Text;
            webBrowser1.Navigate(new Uri(site, UriKind.Absolute));
        }

    }
}
