using RVLiving.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RVLiving.Data
{
    public interface IItemData
    {
        Task<List<ItemModel>> GetItems();
        Task InsertItem(ItemModel item);
        Task DeleteItem(ItemModel item);
        Task UpdateItem(ItemModel item);
    }
}