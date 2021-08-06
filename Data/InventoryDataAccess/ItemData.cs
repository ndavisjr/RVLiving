using RVLiving.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVLiving.Data
{

    public class ItemData : IItemData
    {
        private readonly ISqlDataAccess _db;

        public ItemData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ItemModel>> GetItems()
        {
            string sql = "exec dbo.spInventoryItems_GetAll";

            return _db.LoadData<ItemModel, dynamic>(sql, new { });
        }

        public Task InsertItem(ItemModel item)
        {
            string sql = @"exec dbo.spInventoryItems_InsertInventoryItem @ItemName, @PurchasedFrom, @Category, @Price, @Notes";

            return _db.SaveData(sql, item);
        }

        public Task DeleteItem(ItemModel item)
        {
            string sql = @"exec dbo.spInventoryItems_DeleteInventoryItem @Id";

            return _db.DeleteData(sql, item);
        }

        public Task UpdateItem(ItemModel item)
        {
            string sql = @"exec dbo.spInventoryItems_UpdateInventoryItem  @ItemName, @PurchasedFrom, @Category, @Price, @Notes, @Id";

            return _db.UpdateData(sql, item);
        }
    }
}
