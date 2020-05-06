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
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<RequestViewModel> Requests { get; set; }
        public ObservableCollection<RequestViewModel> Listings { get; set; }
        public MainPage(ObservableCollection<RequestViewModel> Requests, ObservableCollection<RequestViewModel> Listings)
        {
            InitializeComponent();
            this.Requests = Requests;
            this.Listings = Listings;
        }

        public void HandleRequest(object sender, EventArgs args)
        {
            App.Current.MainPage = new RequestPage(Requests, Listings);
            Console.Out.WriteLine("CLICK");
        }
        public void HandleAddRequest(object sender, EventArgs args)
        {
            App.Current.MainPage = new Add_Request(Requests, Listings);
            Console.Out.WriteLine("CLICK");
        }
        public void HandleListing(object sender, EventArgs args)
        {
            App.Current.MainPage = new User_Listings(Requests, Listings);
            Console.Out.WriteLine("CLICK");
        }
        public void HandleAddListing(object sender, EventArgs args)
        {
            App.Current.MainPage = new Add_Listing(Requests, Listings);
            Console.Out.WriteLine("CLICK");
        }

    }
}
