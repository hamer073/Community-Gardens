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
    public partial class MessagesPage : ContentPage 
    {
        public ObservableCollection<RequestViewModel> Requests { get; set; }
        public ObservableCollection<RequestViewModel> Listings { get; set; }

        public MessagesPage(ObservableCollection<RequestViewModel> Messages, ObservableCollection<RequestViewModel> Listings)
        {
            InitializeComponent();
            this.Requests = Messages;
            this.Listings = Listings;
        }

        public void HandleHome(object sender, EventArgs args)
        {
            App.Current.MainPage = new MainPage(Requests, Listings);
        }
    }
}