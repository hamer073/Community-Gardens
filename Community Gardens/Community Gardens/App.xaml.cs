using System;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Xamarin.Forms.Xaml;

namespace Community_Gardens
{
    public partial class App : Application
    {
        public ObservableCollection<RequestViewModel> Requests { get; set; }
        public ObservableCollection<RequestViewModel> Listings { get; set; }
        public App()
        {
            InitializeComponent();
            Requests = new ObservableCollection<RequestViewModel> { };
            Listings = new ObservableCollection<RequestViewModel> { };
            MainPage = new MainPage(Requests, Listings);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
