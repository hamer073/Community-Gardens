using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Community_Gardens
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
public partial class Add_Request : ContentPage
{
    private ObservableCollection<RequestViewModel> requests { get; set; }
    private ObservableCollection<RequestViewModel> listings { get; set; }
    public ICommand AddRequestCommand => new Command(AddRequest);
    public Add_Request(System.Collections.ObjectModel.ObservableCollection<RequestViewModel> requests, System.Collections.ObjectModel.ObservableCollection<RequestViewModel> listings)
    {
        InitializeComponent();
        this.requests = requests;
        this.listings = listings;
        this.BindingContext = this;
    }
    public string product { get; set; }
    public string amount { get; set; }
    public string phone { get; set; }
    public string email { get; set; }
    public void AddRequest()
    {
       requests.Add( new RequestViewModel { Product = product, Amount = amount, Email = email, Phone = phone });
       App.Current.MainPage = new RequestPage(requests, listings);
    }
    }
}