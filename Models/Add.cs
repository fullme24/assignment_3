using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assignment_3.Models
{
    public class Add
    {
        [Required]
        public String Category { get; set; }
        [Required]
        public String Title { get; set; }
        [Required]
        public Int64 Year { get; set; }
        [Required]
        public String Director { get; set; }
        [Required]
        public String Rating { get; set; }
        public String Edited { get; set; }
        public String Lent_to { get; set; }
        public String Notes { get; set; }
    }
}
