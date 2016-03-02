using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
  
namespace FCON_MVC.Models
{
    public class ContactModels
    {
        [Required(ErrorMessage = "In-Game is required. Don't be a stranger!")]
        public string InGameName { get; set; }
        [Required(ErrorMessage = "Email Required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Come-on, I need some infomation to work with!")]
        public string Comment { get; set; }
      
    }
     
}

