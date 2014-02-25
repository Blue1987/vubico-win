using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Vubico.Resources;

namespace Vubico
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Costruttore
        public MainPage()
        {
            InitializeComponent();

        }
 private void HomeClick(object sender, RoutedEventArgs e)
        {
            string site = "https://www.m.google.com";    
            WebBrowser wb = new WebBrowser();
            wb.Navigate(new Uri(site, UriKind.Absolute));
            wb.IsScriptEnabled = true;
        }
    }
}