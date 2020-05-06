using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Community_Gardens
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [System.ComponentModel.DesignTimeVisible(false)]
    public partial class ViewAllListings : ContentPage
    {
        public ViewAllListings()
        {
        }

        public void HandleClicks(object sender, EventArgs args)
        {
            App.Current.MainPage = new Add_Listing();
            Console.Out.WriteLine("CLICK");
        }
    }
}
