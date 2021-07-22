using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RVLiving.Models
{
    public class DisplayExpenseModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Too many characters")]
        public string ExpenseName { get; set; }

        [StringLength(50, ErrorMessage = "Too many characters")]
        public string Amount { get; set; }

        [StringLength(50, ErrorMessage = "Too many characters")]
        public string Category { get; set; }

        [StringLength(250, ErrorMessage = "Too many characters")]
        public string Notes { get; set; }
    }
}
