
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using OfficeWpfTest.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestLibrary;
using TestLibrary.Models;

namespace OfficeWpfTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MenuItem_Click1(object sender, RoutedEventArgs e)
        {
            LoginLayer.Visibility = Visibility.Visible;
        }

        private void MenuItem_Click2a(object sender, RoutedEventArgs e)
        {
            Stage.Child = new UserControl1();
        }

        private void MenuItem_Click2b(object sender, RoutedEventArgs e)
        {
            var win = new Window1();
            win.Show();
        }

        private async void Login_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Resources["ida:AADInstance"].ToString();
            App.Current.Resources["ida:Domain"].ToString();
            App.Current.Resources["ida:ClientId"].ToString();

            AzureAuthenticationSettings settings = new AzureAuthenticationSettings()
            {
                Url = App.Current.Resources["ida:AADInstance"].ToString(),
                ClientId = App.Current.Resources["ida:ClientId"].ToString(),
                RedirectUri = new Uri("http://officewpftest"),
                Resource = "https://api.office.com/discovery/",
                Tenant = App.Current.Resources["ida:Domain"].ToString(),
                PlatformParameters = new PlatformParameters(PromptBehavior.Auto)
            };

            AzureAuthenticationLogic authHelper = new AzureAuthenticationLogic(settings);
            var response = await authHelper.GetAccessToken();
           
            LoginLayer.Visibility = OfficeWpfTest.Model.Authentication.Authenticate1(txtName.Text, txtPassword.Password) ? Visibility.Collapsed : Visibility.Visible;
        }

        internal void RaisePropertyChanged(string prop)
        {
            if (PropertyChanged != null) { PropertyChanged(this, new PropertyChangedEventArgs(prop)); }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
