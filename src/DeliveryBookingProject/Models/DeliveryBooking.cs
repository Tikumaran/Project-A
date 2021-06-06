using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingProject.Models
{
    public class DeliveryBooking
    {
        [Key]
        [Display(Name = "Order ID")]
        public int OrderId { get; set; }

        [Display(Name = "Customer ID")]
        [ForeignKey("Customers")]
        public int CustomerId { get; set; }

        [Display(Name = "Executive ID")]
        [ForeignKey("Executives")]
        public int ExecutiveId { get; set; }

        [Display(Name = "Order Date")]
        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage ="Please Choose Pick Up Date and Time")]
        [Display(Name ="Pick Up Date and Time")]
        [DataType(DataType.DateTime)]
        public DateTime PickUpDateTime { get; set; }

        [Display(Name = "Booking Status")]
        public string BookingStatus { get; set; }

        [Display(Name = "Request Message")]
        [StringLength(50, ErrorMessage = "Message must not be more than 50 Letters")]
        public string Message { get; set; }

        [Display(Name = "Response Message")]
        [StringLength(50, ErrorMessage = "Message must not be more than 50 Letters")]
        public string ResMessage { get; set; }

        [Required(ErrorMessage = "Please Enter Weight of Package in KG")]
        [Display(Name = "Package Weight in KG")]
        [Range(typeof(double), "00.00", "100.49")]
        public double WeightOfPackage { get; set; }

        [Required(ErrorMessage = "Please Click on the Calculate")]
        [Display(Name = "Cost Rs.")]
        public double Price { get; set; }
    }
}
