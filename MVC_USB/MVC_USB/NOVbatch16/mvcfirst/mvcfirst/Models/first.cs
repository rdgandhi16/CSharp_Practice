using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mvcfirst.Models
{

    public class first
    {
        public int id { get; set; }
        [Display(Name="FirstName")]
        [Required(ErrorMessage="Fname is Require...")]
        public string  fname { get; set; }
        [Display(Name = "LastName")]
        [Required(ErrorMessage = "Lname is Require...")]
        public string  lname { get; set; }
    }

}