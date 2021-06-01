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
        [Remote(action: "VerifyUserName", controller: "Customer")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Enter Password")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage ="Required Age")]
        [Display(Name ="Age")]
        public int Age { get; set; }
        [Required(ErrorMessage ="Please Enter Phone Number")]
        [Display(Name ="Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        [Phone(ErrorMessage ="Mobile Number Should Be in 10 Numbers")]
        public long Phone { get; set; }
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
