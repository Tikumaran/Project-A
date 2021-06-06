using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingProject.Models
{
    public class User
    {
        [Key]
        [Required(ErrorMessage = "Please Enter User Name")]
        [Display(Name = "User Name")]
        [Remote(action: "VerifyUserName", controller: "Customer")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Enter Password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please Choose Who You Are?")]
        [Display(Name = "Who You Are?")]
        public string UserType { get; set; }
    }
}
