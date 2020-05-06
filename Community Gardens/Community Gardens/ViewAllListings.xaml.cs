using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using System.Collections.ObjectModel;

namespace Community_Gardens
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [System.ComponentModel.DesignTimeVisible(false)]
    public partial class ViewAllListings : ContentPage
    {
        public ObservableCollection<RequestViewModel> Requests { get; set; }
        public ObservableCollection<RequestViewModel> Listings { get; set; }
        public ViewAllListings(ObservableCollection<RequestViewModel> Requests, ObservableCollection<RequestViewModel> Listings)
        {
            InitializeComponent();
            this.Requests = Requests;
            this.Listings = Listings;
        }

        public void HandleClicks(object sender, EventArgs args)
        {
            App.Current.MainPage = new Add_Listing(Requests, Listings);
        }
        public void HandleHome(object sender, EventArgs args)
        {
            App.Current.MainPage = new MainPage(Requests, Listings);
        }
    }
}
