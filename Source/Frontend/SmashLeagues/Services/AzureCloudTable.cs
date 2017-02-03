using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using SmashLeagues.Abstractions;

namespace SmashLeagues.Services
{
    public class AzureCloudTable<T> : ICloudTable<T> where T : TableData
    {
        private readonly IMobileServiceTable<T> table;

        public AzureCloudTable(MobileServiceClient client)
        {
            table = client.GetTable<T>();
        }

        public async Task<T> CreateItem(T item)
        {
            await table.InsertAsync(item);
            return item;
        }

        public async Task<T> ReadItem(string id)
        {
            return await table.LookupAsync(id);
        }

        public async Task<T> UpdateItem(T item)
        {
            await table.UpdateAsync(item);
            return item;
        }

        public async Task DeleteItem(T item)
        {
            await table.DeleteAsync(item);
        }

        public async Task<ICollection<T>> ReadAllItems()
        {
            return await table.ToListAsync();
        }
    }
}