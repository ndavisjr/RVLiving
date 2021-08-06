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
            string sql = "exec dbo.spExpenseItems_GetAll";

            return _db.LoadData<ExpenseModel, dynamic>(sql, new { });
        }

        public Task InsertExpense(ExpenseModel expense)
        {
            string sql = @"exec dbo.spExpenseItems_InsertExpenseItem @ExpenseName, @Amount, @Category, @Notes";

            return _db.SaveData(sql, expense);
        }

        public Task DeleteExpense(ExpenseModel expense)
        {
            string sql = @"exec dbo.spExpenseItems_DeleteExpenseItem @Id";

            return _db.DeleteData(sql, expense);
        }

        public Task UpdateExpense(ExpenseModel expense)
        {
            string sql = @"exec dbo.spExpenseItems_UpdateExpenseItem  @ExpenseName, @Amount, @Category, @Notes, @Id";

            return _db.UpdateData(sql, expense);
        }
    }
}
