using Android.App;
using Android.Content;
using Android.OS;
using Microsoft.WindowsAzure.MobileServices;

namespace SmashLeagues.Droid
{
    [Activity(Label = "Login", MainLauncher = true, NoHistory = true)]
    public class LoginActivity : Activity
    {
        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            CurrentPlatform.Init();

            var client = new MobileServiceClient(Constants.ApplicationURL);
            App.User = await client.LoginAsync(this, MobileServiceAuthenticationProvider.Google);

            var intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }
    }
}