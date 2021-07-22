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
            string sql = "select * from dbo.InventoryItems";

            return _db.LoadData<ItemModel, dynamic>(sql, new { });
        }

        public Task InsertItem(ItemModel item)
        {
            string sql = @"insert into dbo.InventoryItems (ItemName, PurchasedFrom, Category, Price, Notes)
                            values (@ItemName, @PurchasedFrom, @Category, @Price, @Notes);";

            return _db.SaveData(sql, item);
        }

        public Task DeleteItem(ItemModel item)
        {
            string sql = "delete from dbo.InventoryItems where Id = @Id;";

            return _db.DeleteData(sql, item);
        }

        public Task UpdateItem(ItemModel item)
        {
            string sql = @"update dbo.InventoryItems 
                            set ItemName = @ItemName, PurchasedFrom = @PurchasedFrom, Category = @Category, Price = @Price, Notes = @Notes
                            where Id = @Id;";

            return _db.UpdateData(sql, item);
        }
    }
}
