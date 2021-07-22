using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RVLiving.Models
{
    public class DisplayItemModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Too many characters")]
        public string ItemName { get; set; }

        [StringLength(50, ErrorMessage = "Too many characters")]
        public string PurchasedFrom { get; set; }

        [StringLength(50, ErrorMessage = "Too many characters")]
        public string Category { get; set; }

        public string Price { get; set; }

        [StringLength(250, ErrorMessage = "Too many characters")]
        public string Notes { get; set; }
    }
}
