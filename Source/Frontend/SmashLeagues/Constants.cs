#define LOCAL_

namespace SmashLeagues
{
    public static class Constants
    {
        // Replace strings with your Azure Mobile App endpoint.
        public const string ApplicationURL = @"https://smashleagues.azurewebsites.net";
        public const string LocalURL = @"http://192.168.1.9/SmashLeagues";

#if LOCAL
        public const string Url = LocalURL;

#else
        public const string Url = ApplicationURL;
#endif
    }
}