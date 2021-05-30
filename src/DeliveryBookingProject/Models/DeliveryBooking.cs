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
        public int OrderId { get; set; }
        [ForeignKey("Customers")]
        public int CustomerId { get; set; }
        [ForeignKey("Executives")]
        public int ExecutiveId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime PickUpDateTime { get; set; }
        public string BookingStatus { get; set; }
        public string Message { get; set; }
        public double WeightOfPackage { get; set; }
        public double Price { get; set; }
    }
}
