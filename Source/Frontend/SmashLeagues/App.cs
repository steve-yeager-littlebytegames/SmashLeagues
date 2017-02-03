using System;
using Microsoft.WindowsAzure.MobileServices;
using SmashLeagues.Pages;
using Xamarin.Forms;

namespace SmashLeagues
{
    public class App : Application
    {
        public static string Username { get; set; }

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
            if(string.IsNullOrEmpty(Username))
            {
                MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                MainPage = new NavigationPage(new TodoList());
            }
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