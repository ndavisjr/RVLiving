using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVLiving.Data.Models
{
    public class ExpenseModel
    {
        public int Id { get; set; }
        public string ExpenseName { get; set; }
        public string Amount { get; set; }
        public string Category { get; set; }
        public string Notes { get; set; }


    }
}
