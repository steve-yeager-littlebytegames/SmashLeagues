using Android.App;
using Android.Content.PM;
using Android.OS;

namespace SmashLeagues.Droid
{
    [Activity(Icon = "@drawable/icon",
         MainLauncher = false,
         ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
         Theme = "@android:style/Theme.Holo.Light")]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Initialize Azure Mobile Apps
            Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();

            // Initialize Xamarin Forms
            Xamarin.Forms.Forms.Init(this, bundle);

            // Load the main application
            LoadApplication(new App());
        }
    }
}