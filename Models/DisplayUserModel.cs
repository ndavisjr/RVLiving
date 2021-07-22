using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RVLiving.Models
{
    public class DisplayUserModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "Too many characters")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Too many characters")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
