using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingProject.Models
{
    public class DeliveryBookingContext : DbContext
    {
        public DeliveryBookingContext() 
        {

        }
        public DeliveryBookingContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<DeliveryExecutive> Executives { get; set; }
        public DbSet<DeliveryBooking> DeliveryBookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
