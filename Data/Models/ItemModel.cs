using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVLiving.Data.Models
{
    public class ItemModel
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string PurchasedFrom { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public string Notes { get; set; }
    }
}