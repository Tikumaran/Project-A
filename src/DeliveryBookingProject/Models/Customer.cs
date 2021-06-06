using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingProject.Models
{
    public class Customer
    {
        [Key]
        [Display(Name = "Customer ID")]
        public int CustomerId { get; set; }
        [Required(ErrorMessage ="Please Enter Customer Name")]
        [Display(Name ="Customer Name")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Please Enter User Name")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Enter Password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage ="Required Age")]
        [Display(Name ="Age")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Required phone number")]
        [Display(Name = "Mobile Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[6-9]\d{9}$", ErrorMessage = "Not a valid phone number")]
        //908-908-7895
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please Enter Address")]
        [Display(Name = "Detailed Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Enter City Name")]
        [Display(Name = "City")]
        [StringLength(15, ErrorMessage = "City Name Sholud be 15 Letters")]
        public string City { get; set; }
        public string IsVerified { get; set; }
    }
}
