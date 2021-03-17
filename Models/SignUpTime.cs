using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpGenius.Models
{
    public class SignUpTime
    {
        //This declares the variables for sign ups
        [Key]
        [Required]
        public int SingUpTimeId { get; set; }

        [Required]
        public string Day { get; set; }

        [Required]
        public string Time { get; set; }
    }
}
