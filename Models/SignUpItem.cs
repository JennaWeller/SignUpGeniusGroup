using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpGenius.Models
{
    public class SignUpItem
    {
        //We declare the variables here
        [Key]
        [Required]
        public int SignUpId { get; set; }
        public string NameOfGroup { get; set; }
        [Required]
        public int SizeOfGroup { get; set; }
        [Required]
        public string Email { get; set; }

        //Phone number not required
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }

        public string date { get; set; }

        public string time { get; set; }
    }
}
