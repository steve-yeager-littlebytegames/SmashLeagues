using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;

namespace SmashLeagues
{
    public partial class MainPage : ContentPage
    {
        public const string ApplicationUrl = @"https://smashleagues.azurewebsites.net";
        public static string name = "Steve";

        private MobileServiceClient client;

        public MainPage()
        {
            InitializeComponent();
            client = new MobileServiceClient(ApplicationUrl);
            
        }
    }
}
