using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmashLeagues.Abstractions
{
    public interface ICloudTable<T> where T : TableData
    {
        Task<T> CreateItem(T item);
        Task<T> ReadItem(string id);
        Task<T> UpdateItem(T item);
        Task DeleteItem(T item);
        Task<ICollection<T>> ReadAllItems();
    }
}