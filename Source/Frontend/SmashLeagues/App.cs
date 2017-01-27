using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;

namespace SmashLeagues
{
    public class App : Application
    {
        public static MobileServiceUser User { get; set; }

        public App ()
        {
            // The root page of your application
            MainPage = new TodoList();
        }

        protected override void OnStart ()
        {
            // Handle when your app starts
        }

        protected override void OnSleep ()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume ()
        {
            // Handle when your app resumes
        }
    }
}

