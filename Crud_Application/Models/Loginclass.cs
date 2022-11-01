using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Crud_Application.Models
{
    public class Loginclass
    {
        [Required(ErrorMessage = "Enter the Username")]
        public string uname { get; set; }
        [Required(ErrorMessage = "Enter the Password")]
        public string pwd { get; set; }

        public string msg { get; set; }
    }
}