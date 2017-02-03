using Microsoft.WindowsAzure.MobileServices;
using SmashLeagues.Abstractions;

namespace SmashLeagues.Services
{
    public class AzureCloudService : ICloudService
    {
        private readonly MobileServiceClient client;

        public AzureCloudService()
        {
            client = new MobileServiceClient(@"https://smashleagues.azurewebsites.net");
        }

        public ICloudTable<T> GetTable<T>() where T : TableData
        {
            return new AzureCloudTable<T>(client);
        }
    }
}