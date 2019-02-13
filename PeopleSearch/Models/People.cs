using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleSearch.Models
{
    public class People
    {
        [Key]
        public int PeopleID { get; set; }
        [Required(ErrorMessage = "Please provide your full name.")]
        [Display(Name = "Name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please provide your Address")]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please provide your Age")]
        [Display(Name = "Age")]
        public double Age { get; set; }
        public string Interest { get; set; }
    }
}
