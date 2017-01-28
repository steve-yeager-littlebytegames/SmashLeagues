using System;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;

namespace SmashLeagues
{
    public class App : Application
    {
        private static MobileServiceClient client;

        public static MobileServiceUser User { get; set; }

        public static MobileServiceClient Client
        {
            get
            {
                return client ?? (client = new MobileServiceClient(Constants.Url)
                       {
                           AlternateLoginHost = new Uri(Constants.ApplicationURL)
                       });
            }
        }

        public App()
        {
            // The root page of your application
            MainPage = new TodoList();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}