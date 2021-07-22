using RVLiving.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVLiving.Data
{
    public class ExpenseData : IExpenseData
    {
        private readonly ISqlDataAccess _db;

        public ExpenseData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ExpenseModel>> GetExpenses()
        {
            string sql = "select * from dbo.ExpenseItems";

            return _db.LoadData<ExpenseModel, dynamic>(sql, new { });
        }

        public Task InsertExpense(ExpenseModel expense)
        {
            string sql = @"insert into dbo.ExpenseItems (ExpenseName, Amount, Category, Notes)
                            values (@ExpenseName, @Amount, @Category, @Notes);";

            return _db.SaveData(sql, expense);
        }

        public Task DeleteExpense(ExpenseModel expense)
        {
            string sql = "delete from dbo.ExpenseItems where Id = @Id;";

            return _db.DeleteData(sql, expense);
        }

        public Task UpdateExpense(ExpenseModel expense)
        {
            string sql = @"update dbo.ExpenseItems 
                            set ExpenseName = @ExpenseName, Amount = @Amount, Category = @Category, Notes = @Notes
                            where Id = @Id;";

            return _db.UpdateData(sql, expense);
        }
    }
}
