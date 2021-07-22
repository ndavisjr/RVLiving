using RVLiving.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RVLiving.Data
{
    public interface IExpenseData
    {
        Task<List<ExpenseModel>> GetExpenses();
        Task InsertExpense(ExpenseModel expense);
        Task DeleteExpense(ExpenseModel expense);
        Task UpdateExpense(ExpenseModel expense);
    }
}