using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingProject.Models
{
    public class DeliveryExecutive
    {
        [Key]
        [Display(Name = "Executive ID")]
        public int ExecutiveId { get; set; }
        [Required(ErrorMessage = "Please Enter Executive Name")]
        [Display(Name = "Executive Name")]
        public string ExecutiveName { get; set; }
        [Required(ErrorMessage = "Please Enter User Name")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Enter Password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Required Age")]
        [Display(Name = "Age")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Required phone number")]
        [Display(Name = "Mobile Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please Enter Address")]
        [Display(Name = "Detailed Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Enter City Name")]
        [Display(Name = "City")]
        [StringLength(15,ErrorMessage ="City Name Sholud be 15 Letters")]
        public string City { get; set; }
        public string IsVerified { get; set; }
    }
}
