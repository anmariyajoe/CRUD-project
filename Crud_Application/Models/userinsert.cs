using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Crud_Application.Models
{
    public class userinsert
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Enter the Name")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Enter correct formar")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Entered phone format is not valid.")]
        public string Mobileno { get; set; }
        public string Country { get; set; }
        public string Image { get; set; }
        
        public string Username { get; set; }

        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password Mismatch")]
        public string ConfirmPassword { get; set; }

        public string msg { get; set; }
    }
}