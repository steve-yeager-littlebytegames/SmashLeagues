using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Microsoft.WindowsAzure.MobileServices;

namespace SmashLeagues.Droid
{
    [Activity(MainLauncher = true, NoHistory = true)]
    public class LoginActivity : Activity
    {
        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            CurrentPlatform.Init();

            App.User = await App.Client.LoginAsync(this, MobileServiceAuthenticationProvider.Google);
            App.Username = await GetUsername();

            var intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }

        private static async Task<string> GetUsername()
        {
            Dictionary<string, string> paramaters = new Dictionary<string, string>
            {
                {"id", App.Client.CurrentUser.UserId}
            };
            var task = await App.Client.InvokeApiAsync("Test/GetUser", HttpMethod.Get, paramaters);

            string username = string.Empty;
            if(task.HasValues)
            {
                username = task["username"].ToString();
            }

            return username;
        }
    }
}