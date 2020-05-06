using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace Community_Gardens
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class User_Listings : ContentPage
    {
        public ObservableCollection<RequestViewModel> Requests { get; set; }
        public ObservableCollection<RequestViewModel> Listings { get; set; }
        public User_Listings(ObservableCollection<RequestViewModel> Requests, ObservableCollection<RequestViewModel> Listings)
        {
            InitializeComponent();
            this.Requests = Requests;
            this.Listings = Listings;
            ListingView.ItemsSource = this.Listings;
        }
        public void HandleHome(object sender, EventArgs args)
        {
            App.Current.MainPage = new MainPage(Requests, Listings);
            Console.Out.WriteLine("CLICK");
        }
    }
}